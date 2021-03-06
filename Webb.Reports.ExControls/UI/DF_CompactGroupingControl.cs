/***********************************************************************
 * IDE:Microsoft Development Environment Ver:7.10
 * Module:DF_CompactGroupingControl.cs
 * Author:Country.Wu [EMail:Webb.Country.Wu@163.com]
 * Create Time:11/29/2007 12:59:40 PM
 * Copyright:1986-2007@Webb Electronics all right reserved.
 * Purpose:
 * ***********************************************************************/
#region History
/*
 * //Author@DateTime : Description
 * */
#endregion History

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Webb.Reports.ExControls.UI
{
	public class DF_CompactGroupingControl : Webb.Reports.ExControls.UI.ExControlDesignerFormBase
	{
		private ConfigCompactGroupingInfo _ConfigGroupControl;
		private System.Windows.Forms.LinkLabel C_GroupingSetting;
		private System.Windows.Forms.LinkLabel C_Layout;
		private ConfigGroupingLayout _ConfigLayoutControl;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.LinkLabel C_HeadersConstruct;
		private System.Windows.Forms.LinkLabel C_Matrix;

		private ConfigHeaderConstructor _ConfigHeadersControl;
		private System.Windows.Forms.LinkLabel C_GridSetting; //2008-8-28 9:56:19@simon
        private ConfigMatrixInfo _ConfigMatrixInfo; //2008-8-28 9:56:19@simon
		private ConfigGridInfo _ConfigGridInfo; // 2009-2-17 13:49:11@Simon


		public DF_CompactGroupingControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			this._ConfigGroupControl = new ConfigCompactGroupingInfo();
			this._ConfigLayoutControl = new ConfigGroupingLayout();
			
			//2008-8-28 9:56:11@simon
			this._ConfigHeadersControl=new ConfigHeaderConstructor();
			this._ConfigMatrixInfo=new ConfigMatrixInfo();
             _ConfigGridInfo=new ConfigGridInfo();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.C_GroupingSetting = new System.Windows.Forms.LinkLabel();
			this.C_Layout = new System.Windows.Forms.LinkLabel();
			this.C_HeadersConstruct = new System.Windows.Forms.LinkLabel();
			this.C_Matrix = new System.Windows.Forms.LinkLabel();
			this.C_GridSetting = new System.Windows.Forms.LinkLabel();
			this.C_AllTask.SuspendLayout();
			this.C_LeftMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// _ExControlStyleControl
			// 
			this._ExControlStyleControl.Name = "_ExControlStyleControl";
			// 
			// C_MainPanel
			// 
			this.C_MainPanel.Location = new System.Drawing.Point(165, 0);
			this.C_MainPanel.Name = "C_MainPanel";
			this.C_MainPanel.Size = new System.Drawing.Size(677, 381);
			// 
			// C_AllTask
			// 
			this.C_AllTask.Controls.Add(this.C_HeadersConstruct);
			this.C_AllTask.Controls.Add(this.C_Layout);
			this.C_AllTask.Controls.Add(this.C_GroupingSetting);
			this.C_AllTask.Controls.Add(this.C_Matrix);
			this.C_AllTask.Controls.Add(this.C_GridSetting);
			this.C_AllTask.Name = "C_AllTask";
			this.C_AllTask.Size = new System.Drawing.Size(152, 240);
			this.C_AllTask.Controls.SetChildIndex(this.C_GridSetting, 0);
			this.C_AllTask.Controls.SetChildIndex(this.C_Matrix, 0);
			this.C_AllTask.Controls.SetChildIndex(this.C_GroupingSetting, 0);
			this.C_AllTask.Controls.SetChildIndex(this.C_AutoStyle, 0);
			this.C_AllTask.Controls.SetChildIndex(this.C_Layout, 0);
			this.C_AllTask.Controls.SetChildIndex(this.C_HeadersConstruct, 0);
			// 
			// C_HideOrShowTask
			// 
			this.C_HideOrShowTask.Name = "C_HideOrShowTask";
			// 
			// C_LeftMenu
			// 
			this.C_LeftMenu.Name = "C_LeftMenu";
			this.C_LeftMenu.Size = new System.Drawing.Size(160, 421);
			// 
			// C_Splitter
			// 
			this.C_Splitter.Location = new System.Drawing.Point(160, 0);
			this.C_Splitter.Name = "C_Splitter";
			this.C_Splitter.Size = new System.Drawing.Size(5, 421);
			// 
			// C_AutoStyle
			// 
			this.C_AutoStyle.Location = new System.Drawing.Point(3, 56);
			this.C_AutoStyle.Name = "C_AutoStyle";
			this.C_AutoStyle.Size = new System.Drawing.Size(146, 32);
			// 
			// C_GroupingSetting
			// 
			this.C_GroupingSetting.Dock = System.Windows.Forms.DockStyle.Top;
			this.C_GroupingSetting.Location = new System.Drawing.Point(3, 18);
			this.C_GroupingSetting.Name = "C_GroupingSetting";
			this.C_GroupingSetting.Size = new System.Drawing.Size(146, 38);
			this.C_GroupingSetting.TabIndex = 1;
			this.C_GroupingSetting.TabStop = true;
			this.C_GroupingSetting.Text = "Outer Group Setting";
			this.C_GroupingSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.C_GroupingSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.C_GroupingSetting_LinkClicked);
			// 
			// C_Layout
			// 
			this.C_Layout.Dock = System.Windows.Forms.DockStyle.Top;
			this.C_Layout.Location = new System.Drawing.Point(3, 88);
			this.C_Layout.Name = "C_Layout";
			this.C_Layout.Size = new System.Drawing.Size(146, 32);
			this.C_Layout.TabIndex = 4;
			this.C_Layout.TabStop = true;
			this.C_Layout.Text = "Adjust Size";
			this.C_Layout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.C_Layout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.C_Layout_LinkClicked);
			// 
			// C_HeadersConstruct
			// 
			this.C_HeadersConstruct.Location = new System.Drawing.Point(8, 120);
			this.C_HeadersConstruct.Name = "C_HeadersConstruct";
			this.C_HeadersConstruct.Size = new System.Drawing.Size(136, 32);
			this.C_HeadersConstruct.TabIndex = 5;
			this.C_HeadersConstruct.TabStop = true;
			this.C_HeadersConstruct.Text = "Header Titles";
			this.C_HeadersConstruct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.C_HeadersConstruct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.C_HeadersConstruct_LinkClicked);
			// 
			// C_Matrix
			// 
			this.C_Matrix.Location = new System.Drawing.Point(8, 152);
			this.C_Matrix.Name = "C_Matrix";
			this.C_Matrix.Size = new System.Drawing.Size(136, 32);
			this.C_Matrix.TabIndex = 5;
			this.C_Matrix.TabStop = true;
			this.C_Matrix.Text = "Inner Group Setting";
			this.C_Matrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.C_Matrix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.C_Matrix_LinkClicked);
			// 
			// C_GridSetting
			// 
			this.C_GridSetting.Location = new System.Drawing.Point(8, 184);
			this.C_GridSetting.Name = "C_GridSetting";
			this.C_GridSetting.Size = new System.Drawing.Size(136, 32);
			this.C_GridSetting.TabIndex = 5;
			this.C_GridSetting.TabStop = true;
			this.C_GridSetting.Text = "DisplayGrid Setting";
			this.C_GridSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.C_GridSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.C_GridSetting_LinkClicked);
			// 
			// DF_CompactGroupingControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(842, 421);
			this.Name = "DF_CompactGroupingControl";
			this.Load += new System.EventHandler(this.DF_CompactGroupingControl_Load);
			this.C_AllTask.ResumeLayout(false);
			this.C_LeftMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//Scott@2008-01-02 16:15 modified some of the following code.
		public override void SetView(Webb.Reports.ExControls.Views.ExControlView i_View)
		{
			base.SetView (i_View);

			this.ControlsSetView(this._ExControlView);
		}

		public override void UpdateView(Webb.Reports.ExControls.Views.ExControlView i_View)
		{
			base.UpdateView (i_View);
			
			this.ControlsUpdateView(i_View);
		}

		//on load
		private void DF_CompactGroupingControl_Load(object sender, System.EventArgs e)
		{
			this.ControlsSetView(this._ExControlView);
			
			this.LoadConfigControl(this._ConfigGroupControl);
		}

		//group setting
		private void C_GroupingSetting_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this._ConfigGroupControl.SetView(this._ExControlView);
			
			this.LoadConfigControl(this._ConfigGroupControl);
		}

		//layout setting
		private void C_Layout_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this._ConfigLayoutControl.SetView(this._ExControlView);
			
			this.LoadConfigControl(this._ConfigLayoutControl);
		}

		//ok
		protected override void C_OK_Click(object sender, EventArgs e)
		{
			base.C_OK_Click (sender, e);
			
			this.ControlsUpdateView(this._ExControlView);
			
			this._ExControlView.UpdateView();
		}

		//apply
		protected override void C_Apply_Click(object sender, EventArgs e)
		{
			base.C_Apply_Click (sender, e);
			
			this.ControlsUpdateView(this._ExControlView);

			this._ExControlView.UpdateView();
		}

		private void ControlsUpdateView(Views.ExControlView i_View)
		{
			this._ConfigGroupControl.UpdateView(i_View);
			
			if (this._ConfigLayoutControl.Parent != null) 
			{
				this._ConfigLayoutControl.UpdateView(i_View);

                (i_View as Views.CompactGroupView).WidthEnable=true;
			}
			
			if (this._ConfigHeadersControl.Parent != null)this._ConfigHeadersControl.UpdateView(i_View);

			if (this._ConfigMatrixInfo.Parent != null)this._ConfigMatrixInfo.UpdateView(i_View);

			if (this._ConfigGridInfo.Parent != null)this._ConfigGridInfo.UpdateView(i_View);
		}

		private void ControlsSetView(Views.ExControlView i_View)
		{
			this._ConfigGroupControl.SetView(i_View);
			
			this._ConfigLayoutControl.SetView(i_View);				

            this._ConfigHeadersControl.SetView(i_View); //2008-8-28 9:59:30@simon

			bool Matrix=(i_View as Views.CompactGroupView).Matrix;
			
			if(Matrix)
			{
                this.C_Matrix.Visible=true;

				this.C_GroupingSetting.Text="Outter Group Setting";

				this._ConfigMatrixInfo.SetView(i_View);		

				if((i_View as Views.CompactGroupView).MatrixDisplay==Views.ComputedStyle.Group)
				{
					this.C_GridSetting.Visible=false;
				}
				else
				{
					this.C_GridSetting.Visible=true;

					this._ConfigGridInfo.SetView(i_View); //2008-8-28 9:59:30@simon
				}
			}
			else
			{
				this.C_GroupingSetting.Text="Group Setting";

				this.C_Matrix.Visible=false;

                this.C_GridSetting.Visible=false;
			}

		}

		private void C_HeadersConstruct_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this._ConfigHeadersControl.SetView(this._ExControlView);
			
			this.LoadConfigControl(this._ConfigHeadersControl);
		}

		private void C_Matrix_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this._ConfigMatrixInfo.SetView(this._ExControlView);
			
			this.LoadConfigControl(this._ConfigMatrixInfo);
		}

		private void C_GridSetting_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
	    	this._ConfigGridInfo.SetView(this._ExControlView);
			
			this.LoadConfigControl(this._ConfigGridInfo);
		}
	}
}

