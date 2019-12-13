using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Modern
{
	static class Program
	{

		private static Form1 form1 = null;
		public static Form1 Form1
		{
			get
			{
				if (form1 == null || form1.IsDisposed == true)
				{
					form1 =
						new Form1();
				}

				return form1;
			}
		}

		private static Form2 form2 = null;
		public static Form2 Form2
		{
			get
			{
				if (form2== null || form2.IsDisposed == true)
				{
					form2 =
						new Form2();
				}
				return form2;
			}
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
