﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLogMessage.View
{
	/// <summary>
	/// Interaction logic for LogView.xaml
	/// </summary>
	public partial class LogView : UserControl
	{
		public LogView()
		{
			InitializeComponent();
			var db = new diemongo_dk_dbEntities();
			var log = new LogMessage();
			log.Message = "Hellogoodmorning2";
			db.LogMessage.Add(log);
			db.SaveChanges();
		}
	}
}
