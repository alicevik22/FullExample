using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_UploadOnNET {
    public partial class Form1 : Form {
        static string CurrVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
        static string exeName = AppDomain.CurrentDomain.FriendlyName;
        static string exePath = Assembly.GetExecutingAssembly().Location;
        /*
        public Form1() {
            InitializeComponent();
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
        }
        */
        private async void button1_Click(object sender, EventArgs e) {
            // Этот метод старый
            using (WebClient wc = new WebClient()) {//устарело
                if (Internet.Ok()) {
                    string readVer = wc.DownloadString("http://dotnet.beget.tech/data.php?key= version");
                    if (Convert.ToDouble(CurrVersion, CultureInfo.InstalledUICulture) == Convert.ToDouble(readVer, CultureInfo.InstalledUICulture)) {
                        label1.Text = "Using new Version:" + readVer;
                    } else {
                        label1.Text = "Version new: " + readVer;
                        if (MessageBox.Show("Доступна новая версия. Обновить?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                            wc.DownloadFile("http://dotnet.beget.tech/WinowsFormsApp1.exe", "new.exe");
                            //Cmd($"taskkill /f /im \"{exeName}\" && timeout /t 1 && del \"{exePath}\" && ren new.exe \"{exeName}\" && \"{exePath}\"");
                        }
                    }
                } else {
                    label1.Text = "Not new version";
                }
            }
        }
        
        private async void button2_Click(object sender, EventArgs e) {
            // TODO проработать
        /*    using (HttpClient client = new HttpClient()) {
                if (Internet.Ok()) {
                    string readVer = await HttpResponse("http://dotnet.beget.tech/data.php?key= version");
                    if (Convert.ToDouble(CurrVersion, CultureInfo.InstalledUICulture) == Convert.ToDouble(readVer, CultureInfo.InstalledUICulture)) {
                        label1.Text = "Using new Version:" + readVer;
                    } else {
                        label1.Text = "Version new: " + readVer;
                        if (MessageBox.Show("Доступна новая версия. Обновить?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                            //wc.DownloadFile("http://dotnet.beget.tech/WinowsFormsApp1.exe", "new.exe");
                            using(var stream = await client.GetStreamAsync("http://dotnet.beget.tech/WinowsFormsApp1.exe"))
                            using(var file = new FileStream("new.exe", FileMode.CreateNew))
                            await stream.CopyToAsync(file);
                            Cmd($"taskkill /f /im \"{exeName}\" && timeout /t 1 && del \"{exePath}\" && ren new.exe \"{exeName}\" && \"{exePath}\"");
                        }
                    }
                } else {
                    label1.Text = "Not new version";
                }
            }
        }
        public void Cmd(string line) {
            //добавить сюда
        }
        async Task<string> HttpResponse(string line) {
            using (var net = new HttpClient()) {
                var response = await net.GetAsync(line);
                return response.IsSuccessStatusCode & await response.Content.ReadAsStringAsync() : null;
            }*/
        }
        
        //////23 37
    }
}
