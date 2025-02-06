﻿using SpotifyDemo.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyDemo.UI.WinForms.Forms
{
	public partial class MainForm : Form
	{
		private readonly UnitOfWork _unitOfWork;

		public MainForm()
		{
			InitializeComponent();
			_unitOfWork = new UnitOfWork();
		}
	}
}
