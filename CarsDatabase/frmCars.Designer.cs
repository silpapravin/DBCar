
namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblvehicleregistrationno = new System.Windows.Forms.Label();
            this.lblmake = new System.Windows.Forms.Label();
            this.lblenginesize = new System.Windows.Forms.Label();
            this.lbldateregistered = new System.Windows.Forms.Label();
            this.lblrental = new System.Windows.Forms.Label();
            this.lblavailable = new System.Windows.Forms.Label();
            this.txtvehicleregno = new System.Windows.Forms.TextBox();
            this.txtmake = new System.Windows.Forms.TextBox();
            this.txtenginesize = new System.Windows.Forms.TextBox();
            this.txtdateregistered = new System.Windows.Forms.TextBox();
            this.txtrentalperday = new System.Windows.Forms.TextBox();
            this.chkavailable = new System.Windows.Forms.CheckBox();
            this.txtupdate = new System.Windows.Forms.Button();
            this.txtadd = new System.Windows.Forms.Button();
            this.txtdelete = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.Button();
            this.txtcancel = new System.Windows.Forms.Button();
            this.txtexit = new System.Windows.Forms.Button();
            this.buttonfirst = new System.Windows.Forms.Button();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.txtrecord = new System.Windows.Forms.TextBox();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonlast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.Location = new System.Drawing.Point(233, 13);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(195, 25);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Bowman Car Hire";
            // 
            // lblvehicleregistrationno
            // 
            this.lblvehicleregistrationno.AutoSize = true;
            this.lblvehicleregistrationno.Location = new System.Drawing.Point(40, 70);
            this.lblvehicleregistrationno.Name = "lblvehicleregistrationno";
            this.lblvehicleregistrationno.Size = new System.Drawing.Size(154, 15);
            this.lblvehicleregistrationno.TabIndex = 1;
            this.lblvehicleregistrationno.Text = "Vehicle registration Number";
            // 
            // lblmake
            // 
            this.lblmake.AutoSize = true;
            this.lblmake.Location = new System.Drawing.Point(40, 107);
            this.lblmake.Name = "lblmake";
            this.lblmake.Size = new System.Drawing.Size(36, 15);
            this.lblmake.TabIndex = 2;
            this.lblmake.Text = "Make";
            // 
            // lblenginesize
            // 
            this.lblenginesize.AutoSize = true;
            this.lblenginesize.Location = new System.Drawing.Point(40, 145);
            this.lblenginesize.Name = "lblenginesize";
            this.lblenginesize.Size = new System.Drawing.Size(66, 15);
            this.lblenginesize.TabIndex = 3;
            this.lblenginesize.Text = "Engine Size";
            // 
            // lbldateregistered
            // 
            this.lbldateregistered.AutoSize = true;
            this.lbldateregistered.Location = new System.Drawing.Point(40, 192);
            this.lbldateregistered.Name = "lbldateregistered";
            this.lbldateregistered.Size = new System.Drawing.Size(86, 15);
            this.lbldateregistered.TabIndex = 4;
            this.lbldateregistered.Text = "Date registered";
            // 
            // lblrental
            // 
            this.lblrental.AutoSize = true;
            this.lblrental.Location = new System.Drawing.Point(40, 231);
            this.lblrental.Name = "lblrental";
            this.lblrental.Size = new System.Drawing.Size(82, 15);
            this.lblrental.TabIndex = 5;
            this.lblrental.Text = "Rental per day";
            // 
            // lblavailable
            // 
            this.lblavailable.AutoSize = true;
            this.lblavailable.Location = new System.Drawing.Point(40, 273);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(55, 15);
            this.lblavailable.TabIndex = 6;
            this.lblavailable.Text = "Available";
            // 
            // txtvehicleregno
            // 
            this.txtvehicleregno.Location = new System.Drawing.Point(208, 68);
            this.txtvehicleregno.Name = "txtvehicleregno";
            this.txtvehicleregno.Size = new System.Drawing.Size(183, 23);
            this.txtvehicleregno.TabIndex = 7;
            // 
            // txtmake
            // 
            this.txtmake.Location = new System.Drawing.Point(208, 104);
            this.txtmake.Name = "txtmake";
            this.txtmake.Size = new System.Drawing.Size(183, 23);
            this.txtmake.TabIndex = 8;
            // 
            // txtenginesize
            // 
            this.txtenginesize.Location = new System.Drawing.Point(208, 142);
            this.txtenginesize.Name = "txtenginesize";
            this.txtenginesize.Size = new System.Drawing.Size(183, 23);
            this.txtenginesize.TabIndex = 9;
            // 
            // txtdateregistered
            // 
            this.txtdateregistered.Location = new System.Drawing.Point(208, 191);
            this.txtdateregistered.Name = "txtdateregistered";
            this.txtdateregistered.Size = new System.Drawing.Size(183, 23);
            this.txtdateregistered.TabIndex = 10;
            // 
            // txtrentalperday
            // 
            this.txtrentalperday.Location = new System.Drawing.Point(208, 233);
            this.txtrentalperday.Name = "txtrentalperday";
            this.txtrentalperday.Size = new System.Drawing.Size(183, 23);
            this.txtrentalperday.TabIndex = 11;
            // 
            // chkavailable
            // 
            this.chkavailable.AutoSize = true;
            this.chkavailable.Location = new System.Drawing.Point(218, 273);
            this.chkavailable.Name = "chkavailable";
            this.chkavailable.Size = new System.Drawing.Size(15, 14);
            this.chkavailable.TabIndex = 12;
            this.chkavailable.UseVisualStyleBackColor = true;
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(596, 24);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(124, 43);
            this.txtupdate.TabIndex = 13;
            this.txtupdate.Text = "&Update";
            this.txtupdate.UseVisualStyleBackColor = true;
            this.txtupdate.Click += new System.EventHandler(this.txtupdate_Click);
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(596, 73);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(123, 46);
            this.txtadd.TabIndex = 14;
            this.txtadd.Text = "&Add";
            this.txtadd.UseVisualStyleBackColor = true;
            this.txtadd.Click += new System.EventHandler(this.txtadd_Click);
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(597, 125);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(123, 42);
            this.txtdelete.TabIndex = 15;
            this.txtdelete.Text = "&Delete";
            this.txtdelete.UseVisualStyleBackColor = true;
            this.txtdelete.Click += new System.EventHandler(this.txtdelete_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(597, 177);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(123, 45);
            this.txtsearch.TabIndex = 16;
            this.txtsearch.Text = "&Search";
            this.txtsearch.UseVisualStyleBackColor = true;
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            // 
            // txtcancel
            // 
            this.txtcancel.Location = new System.Drawing.Point(597, 233);
            this.txtcancel.Name = "txtcancel";
            this.txtcancel.Size = new System.Drawing.Size(123, 44);
            this.txtcancel.TabIndex = 17;
            this.txtcancel.Text = "&Cancel";
            this.txtcancel.UseVisualStyleBackColor = true;
            this.txtcancel.Click += new System.EventHandler(this.txtcancel_Click);
            // 
            // txtexit
            // 
            this.txtexit.Location = new System.Drawing.Point(597, 283);
            this.txtexit.Name = "txtexit";
            this.txtexit.Size = new System.Drawing.Size(123, 44);
            this.txtexit.TabIndex = 18;
            this.txtexit.Text = "&Exit";
            this.txtexit.UseVisualStyleBackColor = true;
            this.txtexit.Click += new System.EventHandler(this.txtexit_Click);
            // 
            // buttonfirst
            // 
            this.buttonfirst.Location = new System.Drawing.Point(13, 327);
            this.buttonfirst.Name = "buttonfirst";
            this.buttonfirst.Size = new System.Drawing.Size(109, 35);
            this.buttonfirst.TabIndex = 19;
            this.buttonfirst.Text = "First";
            this.buttonfirst.UseVisualStyleBackColor = true;
            this.buttonfirst.Click += new System.EventHandler(this.buttonfirst_Click);
            // 
            // buttonprevious
            // 
            this.buttonprevious.Location = new System.Drawing.Point(117, 327);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(116, 34);
            this.buttonprevious.TabIndex = 20;
            this.buttonprevious.Text = "Previous";
            this.buttonprevious.UseVisualStyleBackColor = true;
            this.buttonprevious.Click += new System.EventHandler(this.buttonprevious_Click);
            // 
            // txtrecord
            // 
            this.txtrecord.Location = new System.Drawing.Point(233, 334);
            this.txtrecord.Name = "txtrecord";
            this.txtrecord.Size = new System.Drawing.Size(96, 23);
            this.txtrecord.TabIndex = 21;
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(328, 328);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(116, 34);
            this.buttonnext.TabIndex = 22;
            this.buttonnext.Text = "Next";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // buttonlast
            // 
            this.buttonlast.Location = new System.Drawing.Point(440, 327);
            this.buttonlast.Name = "buttonlast";
            this.buttonlast.Size = new System.Drawing.Size(121, 35);
            this.buttonlast.TabIndex = 23;
            this.buttonlast.Text = "Last";
            this.buttonlast.UseVisualStyleBackColor = true;
            this.buttonlast.Click += new System.EventHandler(this.buttonlast_Click);
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.buttonlast);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.txtrecord);
            this.Controls.Add(this.buttonprevious);
            this.Controls.Add(this.buttonfirst);
            this.Controls.Add(this.txtexit);
            this.Controls.Add(this.txtcancel);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtupdate);
            this.Controls.Add(this.chkavailable);
            this.Controls.Add(this.txtrentalperday);
            this.Controls.Add(this.txtdateregistered);
            this.Controls.Add(this.txtenginesize);
            this.Controls.Add(this.txtmake);
            this.Controls.Add(this.txtvehicleregno);
            this.Controls.Add(this.lblavailable);
            this.Controls.Add(this.lblrental);
            this.Controls.Add(this.lbldateregistered);
            this.Controls.Add(this.lblenginesize);
            this.Controls.Add(this.lblmake);
            this.Controls.Add(this.lblvehicleregistrationno);
            this.Controls.Add(this.lbltitle);
            this.Name = "frmCars";
            this.Text = "Task A Silpa Pravin 01/04/2021";
            this.Load += new System.EventHandler(this.frmCars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblvehicleregistrationno;
        private System.Windows.Forms.Label lblmake;
        private System.Windows.Forms.Label lblenginesize;
        private System.Windows.Forms.Label lbldateregistered;
        private System.Windows.Forms.Label lblrental;
        private System.Windows.Forms.Label lblavailable;
        private System.Windows.Forms.TextBox txtvehicleregno;
        private System.Windows.Forms.TextBox txtmake;
        private System.Windows.Forms.TextBox txtenginesize;
        private System.Windows.Forms.TextBox txtdateregistered;
        private System.Windows.Forms.TextBox txtrentalperday;
        private System.Windows.Forms.CheckBox chkavailable;
        private System.Windows.Forms.Button txtupdate;
        private System.Windows.Forms.Button txtadd;
        private System.Windows.Forms.Button txtdelete;
        private System.Windows.Forms.Button txtsearch;
        private System.Windows.Forms.Button txtcancel;
        private System.Windows.Forms.Button txtexit;
        private System.Windows.Forms.Button buttonfirst;
        private System.Windows.Forms.Button buttonprevious;
        private System.Windows.Forms.TextBox txtrecord;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Button buttonlast;
    }
}

