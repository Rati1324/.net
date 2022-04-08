using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace hw5 {
	public partial class Service1 : ServiceBase {
		Model1 db = new Model1();
		string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];

		public Service1() {
			InitializeComponent();
		}
		protected override void OnStop() {
		}

		public void OnDebug() {
			OnStart(null);
		}

		private void OnElapsedTime(object source, ElapsedEventArgs e) {
			int userId = db.Users.Where(i => i.UserName == userName).First().id;
			var userEvents = db.UserEvents.Where(i => i.UserId == userId).Select(ev => ev.EventId).ToList();
			var events = db.Events.Where(ev => userEvents.Any(ev2 => ev2 == ev.id)).ToList();

			DateTime now = DateTime.Now;
			now = now.AddSeconds(-1 * now.Second);
			SqlDateTime sqlNow = new SqlDateTime(now);
			foreach (var item in events) {
				item.EventStart = item.EventStart.AddSeconds(-1 * item.EventStart.Second);
				if (sqlNow.Value == item.EventStart) {
					Write(item);
				}
			}
		}

		protected override void OnStart(string[] args) {
			Timer t = new Timer();
			t.Elapsed += new ElapsedEventHandler(OnElapsedTime);
			t.Interval = 5000;
			t.Enabled = true;
		}

		public void Write(Event data) {
			string path = AppDomain.CurrentDomain.BaseDirectory + "\\Events";
			//using (StreamWriter sw = File.CreateText($"{path}\\test.txt")) {
			//		sw.WriteLine("test");
			//	}
			//}

			if (!Directory.Exists(path)) {
				Directory.CreateDirectory(path);
			}

			path = $"{path}\\{DateTime.Now.Date.ToShortDateString().Replace('/', '_')}_{data.Name}.txt";
			if (!File.Exists(path)) {
				using (StreamWriter sw = File.CreateText(path)) {
					sw.WriteLine($"{data.EventStart} - {data.EventEnd}");
					sw.WriteLine(data.Name);
					sw.WriteLine(data.Description);
				}
			}
		}
	}
}
