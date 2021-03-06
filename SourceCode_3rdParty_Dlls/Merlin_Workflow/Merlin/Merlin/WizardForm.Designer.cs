﻿/*
 * The contributors of Merlin license this file to You under the Apache 
 * License, Version 2.0 (the "License"); you may not use this file except 
 * in compliance with the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

 
 
﻿using System.Drawing;
namespace Merlin
{
    public partial class WizardForm         // DC: made it public
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtSubtitle = new System.Windows.Forms.TextBox();
            this.lblWizardTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlComponentArea = new System.Windows.Forms.Panel();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.pbxLogo);
            this.pnlHeader.Controls.Add(this.txtSubtitle);
            this.pnlHeader.Controls.Add(this.lblWizardTitle);
            this.pnlHeader.Location = new System.Drawing.Point(-1, -2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(510, 63);
            this.pnlHeader.TabIndex = 9999999;
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.BackColor = System.Drawing.Color.White;
            this.txtSubtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSubtitle.Location = new System.Drawing.Point(16, 37);
            this.txtSubtitle.Multiline = true;
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.ReadOnly = true;
            this.txtSubtitle.Size = new System.Drawing.Size(373, 21);
            this.txtSubtitle.TabIndex = 100000000;
            this.txtSubtitle.Text = "Subtitle";
            this.txtSubtitle.Visible = false;
            // 
            // lblWizardTitle
            // 
            this.lblWizardTitle.AutoSize = true;
            this.lblWizardTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWizardTitle.Location = new System.Drawing.Point(12, 18);
            this.lblWizardTitle.Name = "lblWizardTitle";
            this.lblWizardTitle.Size = new System.Drawing.Size(145, 19);
            this.lblWizardTitle.TabIndex = 99999999;
            this.lblWizardTitle.Text = "Component Title";
            this.lblWizardTitle.UseMnemonic = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.Location = new System.Drawing.Point(438, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(68, 61);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pnlComponentArea
            // 
            this.pnlComponentArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlComponentArea.Location = new System.Drawing.Point(0, 64);
            this.pnlComponentArea.Name = "pnlComponentArea";
            this.pnlComponentArea.Size = new System.Drawing.Size(509, 303);
            this.pnlComponentArea.TabIndex = 0;
            // 
            // grpButtons
            // 
            this.grpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpButtons.Controls.Add(this.btnCancel);
            this.grpButtons.Controls.Add(this.btnNext);
            this.grpButtons.Controls.Add(this.btnBack);
            this.grpButtons.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpButtons.Location = new System.Drawing.Point(-14, 353);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(527, 71);
            this.grpButtons.TabIndex = 999999;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = " ";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(415, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 22);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(286, 29);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 22);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "&Next >";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(187, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 22);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "< &Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // WizardForm
            // 
         //   this.AcceptButton = this.btnNext; // was capturing the enter key
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(505, 414);
            this.ControlBox = false;
            this.Controls.Add(this.pnlComponentArea);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WizardForm";
            this.Text = "WizardForm";
            this.Resize += new System.EventHandler(this.WizardForm_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblWizardTitle;
        private System.Windows.Forms.Panel pnlComponentArea;
        private System.Windows.Forms.GroupBox grpButtons;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSubtitle;
    }
}
