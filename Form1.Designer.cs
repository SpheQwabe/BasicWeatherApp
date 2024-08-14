namespace BasicWeatherApp
{
    partial class Form1
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
            this.current_panel = new System.Windows.Forms.Panel();
            this.current_w_temp = new System.Windows.Forms.Label();
            this.apparent_temp = new System.Windows.Forms.Label();
            this.current_w_desc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hourly_panel = new System.Windows.Forms.Panel();
            this.daily_panel = new System.Windows.Forms.Panel();
            this.current_w_image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.current_humidity = new System.Windows.Forms.Label();
            this.current_wind_speed = new System.Windows.Forms.Label();
            this.current_dew_point = new System.Windows.Forms.Label();
            this.current_snowfall = new System.Windows.Forms.Label();
            this.current_rain = new System.Windows.Forms.Label();
            this.current_visibility = new System.Windows.Forms.Label();
            this.current_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_w_image)).BeginInit();
            this.SuspendLayout();
            // 
            // current_panel
            // 
            this.current_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.current_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_panel.Controls.Add(this.current_visibility);
            this.current_panel.Controls.Add(this.current_rain);
            this.current_panel.Controls.Add(this.current_snowfall);
            this.current_panel.Controls.Add(this.current_dew_point);
            this.current_panel.Controls.Add(this.current_wind_speed);
            this.current_panel.Controls.Add(this.current_humidity);
            this.current_panel.Controls.Add(this.label7);
            this.current_panel.Controls.Add(this.label6);
            this.current_panel.Controls.Add(this.label5);
            this.current_panel.Controls.Add(this.label4);
            this.current_panel.Controls.Add(this.label3);
            this.current_panel.Controls.Add(this.label2);
            this.current_panel.Controls.Add(this.current_w_image);
            this.current_panel.Controls.Add(this.current_w_temp);
            this.current_panel.Controls.Add(this.apparent_temp);
            this.current_panel.Controls.Add(this.current_w_desc);
            this.current_panel.Controls.Add(this.label1);
            this.current_panel.Location = new System.Drawing.Point(12, 13);
            this.current_panel.Name = "current_panel";
            this.current_panel.Size = new System.Drawing.Size(750, 243);
            this.current_panel.TabIndex = 0;
            // 
            // current_w_temp
            // 
            this.current_w_temp.AutoSize = true;
            this.current_w_temp.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_w_temp.ForeColor = System.Drawing.SystemColors.Control;
            this.current_w_temp.Location = new System.Drawing.Point(3, 145);
            this.current_w_temp.Name = "current_w_temp";
            this.current_w_temp.Size = new System.Drawing.Size(161, 67);
            this.current_w_temp.TabIndex = 3;
            this.current_w_temp.Text = "temp";
            // 
            // apparent_temp
            // 
            this.apparent_temp.AutoSize = true;
            this.apparent_temp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apparent_temp.ForeColor = System.Drawing.SystemColors.Control;
            this.apparent_temp.Location = new System.Drawing.Point(158, 123);
            this.apparent_temp.Name = "apparent_temp";
            this.apparent_temp.Size = new System.Drawing.Size(83, 19);
            this.apparent_temp.TabIndex = 2;
            this.apparent_temp.Text = "app-temp";
            // 
            // current_w_desc
            // 
            this.current_w_desc.AutoSize = true;
            this.current_w_desc.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_w_desc.ForeColor = System.Drawing.SystemColors.Control;
            this.current_w_desc.Location = new System.Drawing.Point(156, 75);
            this.current_w_desc.Name = "current_w_desc";
            this.current_w_desc.Size = new System.Drawing.Size(156, 33);
            this.current_w_desc.TabIndex = 1;
            this.current_w_desc.Text = "temp-desc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Weather";
            // 
            // hourly_panel
            // 
            this.hourly_panel.AutoScroll = true;
            this.hourly_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hourly_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hourly_panel.Location = new System.Drawing.Point(12, 261);
            this.hourly_panel.Name = "hourly_panel";
            this.hourly_panel.Size = new System.Drawing.Size(750, 337);
            this.hourly_panel.TabIndex = 1;
            // 
            // daily_panel
            // 
            this.daily_panel.AutoScroll = true;
            this.daily_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.daily_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daily_panel.Location = new System.Drawing.Point(768, 13);
            this.daily_panel.Name = "daily_panel";
            this.daily_panel.Size = new System.Drawing.Size(729, 585);
            this.daily_panel.TabIndex = 2;
            // 
            // current_w_image
            // 
            this.current_w_image.Location = new System.Drawing.Point(2, 44);
            this.current_w_image.Name = "current_w_image";
            this.current_w_image.Size = new System.Drawing.Size(100, 100);
            this.current_w_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.current_w_image.TabIndex = 4;
            this.current_w_image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(431, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Humidity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(618, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wind Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(431, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dew Point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(618, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Snowfall";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(431, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rain";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(618, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Visibility";
            // 
            // current_humidity
            // 
            this.current_humidity.AutoSize = true;
            this.current_humidity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_humidity.ForeColor = System.Drawing.SystemColors.Control;
            this.current_humidity.Location = new System.Drawing.Point(431, 46);
            this.current_humidity.Name = "current_humidity";
            this.current_humidity.Size = new System.Drawing.Size(105, 24);
            this.current_humidity.TabIndex = 11;
            this.current_humidity.Text = "[humidity]";
            // 
            // current_wind_speed
            // 
            this.current_wind_speed.AutoSize = true;
            this.current_wind_speed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_wind_speed.ForeColor = System.Drawing.SystemColors.Control;
            this.current_wind_speed.Location = new System.Drawing.Point(618, 46);
            this.current_wind_speed.Name = "current_wind_speed";
            this.current_wind_speed.Size = new System.Drawing.Size(125, 24);
            this.current_wind_speed.TabIndex = 12;
            this.current_wind_speed.Text = "[windspeed]";
            // 
            // current_dew_point
            // 
            this.current_dew_point.AutoSize = true;
            this.current_dew_point.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_dew_point.ForeColor = System.Drawing.SystemColors.Control;
            this.current_dew_point.Location = new System.Drawing.Point(431, 104);
            this.current_dew_point.Name = "current_dew_point";
            this.current_dew_point.Size = new System.Drawing.Size(110, 24);
            this.current_dew_point.TabIndex = 13;
            this.current_dew_point.Text = "[dewpoint]";
            // 
            // current_snowfall
            // 
            this.current_snowfall.AutoSize = true;
            this.current_snowfall.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_snowfall.ForeColor = System.Drawing.SystemColors.Control;
            this.current_snowfall.Location = new System.Drawing.Point(618, 104);
            this.current_snowfall.Name = "current_snowfall";
            this.current_snowfall.Size = new System.Drawing.Size(102, 24);
            this.current_snowfall.TabIndex = 14;
            this.current_snowfall.Text = "[snowfall]";
            // 
            // current_rain
            // 
            this.current_rain.AutoSize = true;
            this.current_rain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_rain.ForeColor = System.Drawing.SystemColors.Control;
            this.current_rain.Location = new System.Drawing.Point(431, 164);
            this.current_rain.Name = "current_rain";
            this.current_rain.Size = new System.Drawing.Size(60, 24);
            this.current_rain.TabIndex = 15;
            this.current_rain.Text = "[rain]";
            // 
            // current_visibility
            // 
            this.current_visibility.AutoSize = true;
            this.current_visibility.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_visibility.ForeColor = System.Drawing.SystemColors.Control;
            this.current_visibility.Location = new System.Drawing.Point(618, 164);
            this.current_visibility.Name = "current_visibility";
            this.current_visibility.Size = new System.Drawing.Size(101, 24);
            this.current_visibility.TabIndex = 16;
            this.current_visibility.Text = "[visibility]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 614);
            this.Controls.Add(this.daily_panel);
            this.Controls.Add(this.hourly_panel);
            this.Controls.Add(this.current_panel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Basic Weather App";
            this.current_panel.ResumeLayout(false);
            this.current_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_w_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel current_panel;
        private System.Windows.Forms.Panel hourly_panel;
        private System.Windows.Forms.Panel daily_panel;
        private System.Windows.Forms.Label current_w_temp;
        private System.Windows.Forms.Label apparent_temp;
        private System.Windows.Forms.Label current_w_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox current_w_image;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label current_wind_speed;
        private System.Windows.Forms.Label current_humidity;
        private System.Windows.Forms.Label current_visibility;
        private System.Windows.Forms.Label current_rain;
        private System.Windows.Forms.Label current_snowfall;
        private System.Windows.Forms.Label current_dew_point;
    }
}

