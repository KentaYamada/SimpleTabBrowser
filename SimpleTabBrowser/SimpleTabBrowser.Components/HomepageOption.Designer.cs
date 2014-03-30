namespace SimpleTabBrowser.Components
{
	partial class HomepageOption
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rdoOther = new System.Windows.Forms.RadioButton();
			this.rdoYahoo = new System.Windows.Forms.RadioButton();
			this.rdoGoogle = new System.Windows.Forms.RadioButton();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.txtTitle);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtURL);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.rdoOther);
			this.panel1.Controls.Add(this.rdoYahoo);
			this.panel1.Controls.Add(this.rdoGoogle);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 192);
			this.panel1.TabIndex = 0;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(80, 136);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(240, 20);
			this.txtTitle.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "タイトル:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtURL
			// 
			this.txtURL.Location = new System.Drawing.Point(80, 112);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(240, 20);
			this.txtURL.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "URL:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rdoOther
			// 
			this.rdoOther.AutoSize = true;
			this.rdoOther.Location = new System.Drawing.Point(8, 84);
			this.rdoOther.Name = "rdoOther";
			this.rdoOther.Size = new System.Drawing.Size(59, 17);
			this.rdoOther.TabIndex = 2;
			this.rdoOther.Text = "その他";
			this.rdoOther.UseVisualStyleBackColor = true;
			this.rdoOther.CheckedChanged += new System.EventHandler(this.rdoOther_CheckedChanged);
			// 
			// rdoYahoo
			// 
			this.rdoYahoo.AutoSize = true;
			this.rdoYahoo.Location = new System.Drawing.Point(8, 48);
			this.rdoYahoo.Name = "rdoYahoo";
			this.rdoYahoo.Size = new System.Drawing.Size(63, 17);
			this.rdoYahoo.TabIndex = 1;
			this.rdoYahoo.Text = "Yahoo!";
			this.rdoYahoo.UseVisualStyleBackColor = true;
			// 
			// rdoGoogle
			// 
			this.rdoGoogle.AutoSize = true;
			this.rdoGoogle.Checked = true;
			this.rdoGoogle.Location = new System.Drawing.Point(8, 12);
			this.rdoGoogle.Name = "rdoGoogle";
			this.rdoGoogle.Size = new System.Drawing.Size(64, 17);
			this.rdoGoogle.TabIndex = 0;
			this.rdoGoogle.TabStop = true;
			this.rdoGoogle.Text = "Google";
			this.rdoGoogle.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(208, 204);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(288, 204);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "キャンセル";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// HomepageOption
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(370, 233);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Name = "HomepageOption";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ホームページ設定";
			this.Load += new System.EventHandler(this.HomepageOption_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdoOther;
		private System.Windows.Forms.RadioButton rdoYahoo;
		private System.Windows.Forms.RadioButton rdoGoogle;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}