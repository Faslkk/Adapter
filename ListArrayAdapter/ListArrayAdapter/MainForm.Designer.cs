namespace ListArrayAdapter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblList = new System.Windows.Forms.Label();
            this.txtListValue = new System.Windows.Forms.TextBox();
            this.btnListAdd = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.btnListToArray = new System.Windows.Forms.Button();
            this.lblArray = new System.Windows.Forms.Label();
            this.txtArrayValues = new System.Windows.Forms.TextBox();
            this.btnArrayCreate = new System.Windows.Forms.Button();
            this.lstArray = new System.Windows.Forms.ListBox();
            this.btnArrayToList = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.btnAdapterAdd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblList.Location = new System.Drawing.Point(12, 12);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(290, 20);
            this.lblList.Text = "Список (ListData):";
            this.txtListValue.Location = new System.Drawing.Point(12, 34);
            this.txtListValue.Name = "txtListValue";
            this.txtListValue.Size = new System.Drawing.Size(180, 23);
            this.txtListValue.TabIndex = 0;
            this.btnListAdd.Location = new System.Drawing.Point(198, 33);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(104, 25);
            this.btnListAdd.TabIndex = 1;
            this.btnListAdd.Text = "Додати";
            this.btnListAdd.UseVisualStyleBackColor = true;
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            this.lstList.Location = new System.Drawing.Point(12, 66);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(290, 244);
            this.lstList.ItemHeight = 15;
            this.lstList.TabIndex = 2;
            this.btnListToArray.Location = new System.Drawing.Point(12, 318);
            this.btnListToArray.Name = "btnListToArray";
            this.btnListToArray.Size = new System.Drawing.Size(290, 32);
            this.btnListToArray.TabIndex = 3;
            this.btnListToArray.Text = "Список → масив";
            this.btnListToArray.UseVisualStyleBackColor = true;
            this.btnListToArray.Click += new System.EventHandler(this.btnListToArray_Click);
            this.lblArray.Location = new System.Drawing.Point(318, 12);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(290, 20);
            this.lblArray.Text = "Масив (ArrayData), числа через пробіл:";
            this.txtArrayValues.Location = new System.Drawing.Point(318, 34);
            this.txtArrayValues.Name = "txtArrayValues";
            this.txtArrayValues.Size = new System.Drawing.Size(180, 23);
            this.txtArrayValues.TabIndex = 4;
            this.btnArrayCreate.Location = new System.Drawing.Point(504, 33);
            this.btnArrayCreate.Name = "btnArrayCreate";
            this.btnArrayCreate.Size = new System.Drawing.Size(104, 25);
            this.btnArrayCreate.TabIndex = 5;
            this.btnArrayCreate.Text = "Створити";
            this.btnArrayCreate.UseVisualStyleBackColor = true;
            this.btnArrayCreate.Click += new System.EventHandler(this.btnArrayCreate_Click);
            this.lstArray.Location = new System.Drawing.Point(318, 66);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(290, 244);
            this.lstArray.ItemHeight = 15;
            this.lstArray.TabIndex = 6;
            this.btnArrayToList.Location = new System.Drawing.Point(318, 318);
            this.btnArrayToList.Name = "btnArrayToList";
            this.btnArrayToList.Size = new System.Drawing.Size(290, 32);
            this.btnArrayToList.TabIndex = 7;
            this.btnArrayToList.Text = "Масив → список";
            this.btnArrayToList.UseVisualStyleBackColor = true;
            this.btnArrayToList.Click += new System.EventHandler(this.btnArrayToList_Click);
            this.lblAdd.Location = new System.Drawing.Point(318, 366);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(130, 20);
            this.lblAdd.Text = "Add() через адаптер:";
            this.txtAddValue.Location = new System.Drawing.Point(450, 362);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(58, 23);
            this.txtAddValue.TabIndex = 8;
            this.btnAdapterAdd.Location = new System.Drawing.Point(514, 361);
            this.btnAdapterAdd.Name = "btnAdapterAdd";
            this.btnAdapterAdd.Size = new System.Drawing.Size(94, 25);
            this.btnAdapterAdd.TabIndex = 9;
            this.btnAdapterAdd.Text = "Додати";
            this.btnAdapterAdd.UseVisualStyleBackColor = true;
            this.btnAdapterAdd.Click += new System.EventHandler(this.btnAdapterAdd_Click);
            this.lblInfo.Location = new System.Drawing.Point(12, 400);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(596, 48);
            this.lblInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAdapterAdd);
            this.Controls.Add(this.txtAddValue);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnArrayToList);
            this.Controls.Add(this.lstArray);
            this.Controls.Add(this.btnArrayCreate);
            this.Controls.Add(this.txtArrayValues);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.btnListToArray);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnListAdd);
            this.Controls.Add(this.txtListValue);
            this.Controls.Add(this.lblList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адаптер: список і масив";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TextBox txtListValue;
        private System.Windows.Forms.Button btnListAdd;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Button btnListToArray;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.TextBox txtArrayValues;
        private System.Windows.Forms.Button btnArrayCreate;
        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.Button btnArrayToList;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtAddValue;
        private System.Windows.Forms.Button btnAdapterAdd;
        private System.Windows.Forms.Label lblInfo;
    }
}
