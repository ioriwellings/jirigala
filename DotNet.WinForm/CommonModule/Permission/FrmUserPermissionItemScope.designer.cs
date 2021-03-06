﻿namespace DotNet.WinForm
{
    partial class FrmUserPermissionItemScope
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的主键

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用主键编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserPermissionItemScope));
            this.lblUser = new System.Windows.Forms.Label();
            this.tvPermission = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnInvertSelect = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBatchSave = new System.Windows.Forms.Button();
            this.lblParentReq = new System.Windows.Forms.Label();
            this.ucUser = new DotNet.WinForm.UCUserSelect();
            this.tcPermission = new System.Windows.Forms.TabControl();
            this.tpPermission = new System.Windows.Forms.TabPage();
            this.tcPermission.SuspendLayout();
            this.tpPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(15, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(108, 12);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "用户(&U)：";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tvPermission
            // 
            this.tvPermission.CheckBoxes = true;
            this.tvPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPermission.ImageIndex = 0;
            this.tvPermission.ImageList = this.imageList;
            this.tvPermission.Location = new System.Drawing.Point(3, 3);
            this.tvPermission.Name = "tvPermission";
            this.tvPermission.SelectedImageIndex = 1;
            this.tvPermission.Size = new System.Drawing.Size(661, 426);
            this.tvPermission.TabIndex = 4;
            this.tvPermission.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvPermission_BeforeCheck);
            this.tvPermission.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvPermission_AfterCheck);
            this.tvPermission.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvPermission_MouseDown);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            this.imageList.Images.SetKeyName(5, "");
            this.imageList.Images.SetKeyName(6, "");
            this.imageList.Images.SetKeyName(7, "");
            this.imageList.Images.SetKeyName(8, "");
            this.imageList.Images.SetKeyName(9, "");
            this.imageList.Images.SetKeyName(10, "");
            this.imageList.Images.SetKeyName(11, "");
            this.imageList.Images.SetKeyName(12, "");
            this.imageList.Images.SetKeyName(13, "");
            this.imageList.Images.SetKeyName(14, "");
            this.imageList.Images.SetKeyName(15, "icon_messenger1.gif");
            this.imageList.Images.SetKeyName(16, "icon_messenger0.gif");
            this.imageList.Images.SetKeyName(17, "icon_messenger2.gif");
            this.imageList.Images.SetKeyName(18, "icon_messenger3.gif");
            this.imageList.Images.SetKeyName(19, "icon_messenger4.gif");
            this.imageList.Images.SetKeyName(20, "icon_messenger5.gif");
            this.imageList.Images.SetKeyName(21, "icon_messenger6.gif");
            // 
            // btnInvertSelect
            // 
            this.btnInvertSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvertSelect.Location = new System.Drawing.Point(94, 504);
            this.btnInvertSelect.Name = "btnInvertSelect";
            this.btnInvertSelect.Size = new System.Drawing.Size(78, 23);
            this.btnInvertSelect.TabIndex = 7;
            this.btnInvertSelect.Text = "反选";
            this.btnInvertSelect.UseVisualStyleBackColor = true;
            this.btnInvertSelect.Click += new System.EventHandler(this.btnInvertSelect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(8, 504);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(78, 23);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(605, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBatchSave
            // 
            this.btnBatchSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchSave.Location = new System.Drawing.Point(519, 504);
            this.btnBatchSave.Name = "btnBatchSave";
            this.btnBatchSave.Size = new System.Drawing.Size(78, 23);
            this.btnBatchSave.TabIndex = 5;
            this.btnBatchSave.Text = "保存(&S)";
            this.btnBatchSave.UseVisualStyleBackColor = true;
            this.btnBatchSave.Click += new System.EventHandler(this.btnBatchSave_Click);
            // 
            // lblParentReq
            // 
            this.lblParentReq.AutoSize = true;
            this.lblParentReq.ForeColor = System.Drawing.Color.Red;
            this.lblParentReq.Location = new System.Drawing.Point(405, 13);
            this.lblParentReq.Name = "lblParentReq";
            this.lblParentReq.Size = new System.Drawing.Size(11, 12);
            this.lblParentReq.TabIndex = 3;
            this.lblParentReq.Text = "*";
            // 
            // ucUser
            // 
            this.ucUser.AllowNull = true;
            this.ucUser.AllowSelect = false;
            this.ucUser.Location = new System.Drawing.Point(124, 9);
            this.ucUser.MultiSelect = false;
            this.ucUser.Name = "ucUser";
            this.ucUser.OpenId = "";
            this.ucUser.PermissionItemScopeCode = "";
            this.ucUser.RemoveIds = null;
            this.ucUser.SelectedFullName = "";
            this.ucUser.SelectedId = "";
            this.ucUser.SelectedIds = null;
            this.ucUser.SetSelectIds = null;
            this.ucUser.Size = new System.Drawing.Size(275, 22);
            this.ucUser.TabIndex = 2;
            this.ucUser.SelectedIndexChanged += new DotNet.Utilities.BaseBusinessLogic.SelectedIndexChangedEventHandler(this.ucStaffSelect_SelectedIndexChanged);
            // 
            // tcPermission
            // 
            this.tcPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPermission.Controls.Add(this.tpPermission);
            this.tcPermission.Location = new System.Drawing.Point(10, 42);
            this.tcPermission.Name = "tcPermission";
            this.tcPermission.SelectedIndex = 0;
            this.tcPermission.Size = new System.Drawing.Size(675, 458);
            this.tcPermission.TabIndex = 8;
            // 
            // tpPermission
            // 
            this.tpPermission.Controls.Add(this.tvPermission);
            this.tpPermission.Location = new System.Drawing.Point(4, 22);
            this.tpPermission.Name = "tpPermission";
            this.tpPermission.Padding = new System.Windows.Forms.Padding(3);
            this.tpPermission.Size = new System.Drawing.Size(667, 432);
            this.tpPermission.TabIndex = 0;
            this.tpPermission.Text = "操作权限";
            this.tpPermission.UseVisualStyleBackColor = true;
            // 
            // FrmUserPermissionItemScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(692, 533);
            this.Controls.Add(this.tcPermission);
            this.Controls.Add(this.ucUser);
            this.Controls.Add(this.lblParentReq);
            this.Controls.Add(this.btnInvertSelect);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBatchSave);
            this.Controls.Add(this.lblUser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FrmUserPermissionItemScope";
            this.Text = "用户可授权范围设置";
            this.Load += new System.EventHandler(this.FrmUserPermission_Load);
            this.tcPermission.ResumeLayout(false);
            this.tpPermission.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TreeView tvPermission;
        private System.Windows.Forms.Button btnInvertSelect;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBatchSave;
        private System.Windows.Forms.Label lblParentReq;
        private DotNet.WinForm.UCUserSelect ucUser;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabControl tcPermission;
        private System.Windows.Forms.TabPage tpPermission;
    }
}