﻿using System;
using System.Diagnostics;
using System.Reflection;
using Syncfusion.Windows.Forms;

namespace Analogy
{
    partial class AnalogyAboutBox : MetroForm
    {
        private string githubAnalogyNLog = "https://github.com/Analogy-LogViewer/Analogy.LogViewer.NLog";
        private string githubAnalogyRSSParser = "https://github.com/Analogy-LogViewer/Analogy.LogViewer.RSSReader";
        private string githubAnalogyIISParser = "https://github.com/Analogy-LogViewer/Analogy.LogViewer.IISLogParser";
        private string githubAnalogyKafkaProvider= "https://github.com/Analogy-LogViewer/Analogy.LogViewer.KafkaProvider";
        private string githubAnalogyWindowsEventLogs ="https://github.com/Analogy-LogViewer/Analogy.LogViewer.WindowsEventLogs";
        private string philips = "https://www.philips.com/global";
        private string kama = "https://www.linkedin.com/company/kama-research-ltd/about/";
        public AnalogyAboutBox()
        {
            InitializeComponent();
            this.Text = string.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = string.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription + $"{Environment.NewLine}Created by Lior Banai (2017){Environment.NewLine}Contact info:{Environment.NewLine}mail: Liorbanai@gmail.com";

           
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void lblNlog_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(githubAnalogyNLog);
        }

        private void lblRSS_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(githubAnalogyRSSParser);

        }

        private void lblIIS_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(githubAnalogyIISParser);
        }

        private void lblKafka_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(githubAnalogyKafkaProvider);
        }

        private void lblPhilips_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(philips);
        }

        private void lblWindowsEventLogs_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(githubAnalogyWindowsEventLogs);
        }

        private void lblKama_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(kama);
        }
    }
}
