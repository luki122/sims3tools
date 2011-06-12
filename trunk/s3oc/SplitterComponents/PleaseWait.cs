﻿/***************************************************************************
 *  Copyright (C) 2009 by Peter L Jones                                    *
 *  pljones@users.sf.net                                                   *
 *                                                                         *
 *  This file is part of the Sims 3 Package Interface (s3pi)               *
 *                                                                         *
 *  s3pi is free software: you can redistribute it and/or modify           *
 *  it under the terms of the GNU General Public License as published by   *
 *  the Free Software Foundation, either version 3 of the License, or      *
 *  (at your option) any later version.                                    *
 *                                                                         *
 *  s3pi is distributed in the hope that it will be useful,                *
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of         *
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the          *
 *  GNU General Public License for more details.                           *
 *                                                                         *
 *  You should have received a copy of the GNU General Public License      *
 *  along with s3pi.  If not, see <http://www.gnu.org/licenses/>.          *
 ***************************************************************************/
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ObjectCloner.SplitterComponents
{
    public partial class PleaseWait : UserControl
    {
        public PleaseWait()
        {
            InitializeComponent();
        }
        public string Label { get { return label1.Text; } set { label1.Text = value; } }

        public static string DoWait(Control control, string Label = "Please wait...", string Key = "pleaseWait1")
        {
            PleaseWait pw = new PleaseWait() { Dock = DockStyle.Fill, Label = Label, Name = Key, };
            control.Controls.Add(pw);
            return pw.Name;
        }

        public static void StopWait(Control control, string Key = "pleaseWait1") { control.Controls.RemoveByKey(Key); }
    }
}
