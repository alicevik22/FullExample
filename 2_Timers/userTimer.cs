using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Timers {

    /** пример:
    userTimer PeriodicTic = new userTimer(new cyclic(), 500);
    PeriodicTic.eventTimer += eventEndTick;
    PeriodicTic.Start();
    PeriodicTic.Stop(); 
    */
    class userTimer {
        private IMode _Mode = null;
        private int _delayMs;

        // событие на срабатывание
        public event EventHandler eventTimer;

        // установка паузы в ms (при изменении необходимо останавливать таймер)
        public int delayMs {
            get { return _delayMs; }
            set {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException();
                _delayMs = value;
            }
        }

        // конструкторы
        public userTimer() {
            _Mode = new single();
        }
        public userTimer(int value) {
            delayMs = value;
        }
        public userTimer(IMode mode, int value) {
            _Mode = mode;
            delayMs = value;
        }

        // установка режима таймера
        public void setMode(IMode mode) {
            _Mode = mode;
        }

        // старт таймера (при закрытии окна незабыть остановить таймер)
        public void Start() {
            ProcessStart(delayMs);
        }

        public void Start(int value) {
            ProcessStart(value);
        }

        private void ProcessStart(int value) {
            if (_Mode.StartToken) return;
            if (delayMs != value) delayMs = value;
            _Mode.EEndIteration += eventTimer;
            _Mode.Start(_delayMs);
        }

        // стоп таймера
        public void Stop() {
            _Mode.EEndIteration -= eventTimer;
            _Mode.StartToken = false;
        }
    }

    // интерфейс
    public interface IMode {
        bool StartToken { get; set; }
        void Start(int delayMs);
        event EventHandler EEndIteration;
    }

    // режим одиночный
    class single : IMode {
        public bool StartToken { get; set; }
        public event EventHandler EEndIteration;
        async void IMode.Start(int delayMs) {
            await Task.Run(() => {
                Task.Delay(delayMs).Wait();
            });
            if (EEndIteration != null)
                EEndIteration.Invoke(this, EventArgs.Empty);
        }
    }

    // режим цикличный
    class cyclic : IMode {
        public bool StartToken { get; set; }
        public event EventHandler EEndIteration;
        async void IMode.Start(int delayMs) {
            StartToken = true;
            while (true) {

                await Task.Run(() => {
                    Task.Delay(delayMs).Wait();
                });
                if (!StartToken) return;
                if (EEndIteration != null)
                    EEndIteration.Invoke(this, EventArgs.Empty);
            }
        }
    }
}