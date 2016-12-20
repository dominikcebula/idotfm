/*
 * iDotFm - LastFm scrobbler for iTunes
 * Dominik Cebula
 * dominikcebula@gmail.com
 * gg: 3837462
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using Ini;
using System.IO;
using System.Windows.Forms;
using Lastfm;

namespace iDotFm
{
    class Config
    {
        private IniFile ini;

        public String m_user;
        public String m_md5pass;

        public static String GetAppPath()
        {
            FileInfo executableFileInfo = new FileInfo(Application.ExecutablePath);
            return executableFileInfo.DirectoryName + "\\";
        }

        public void FromForm(main fmain)
        {
            if (fmain.tbUser.Text == "")
                throw new Exception("Please write down your username");
            if (fmain.tbPass.Text == "")
                throw new Exception("Please write down your password");

            m_user = fmain.tbUser.Text;
            if (fmain.tbPass.Text != "**************")
                m_md5pass = Utilities.MD5(fmain.tbPass.Text);
        }

        public void ToForm(main f)
        {
            f.tbUser.Text=m_user;
            if (m_md5pass!="")
                f.tbPass.Text = "**************";
        }

        public void LoadSettings()
        {
            ini = new IniFile(GetAppPath() + "config.ini");
            m_user=ini.IniReadValue("iDotFm", "user");
            m_md5pass=ini.IniReadValue("iDotFm", "md5pass");
        }

        public void SaveSettings()
        {
            ini = new IniFile(GetAppPath() + "config.ini");
            ini.IniWriteValue("iDotFm", "user", m_user);
            ini.IniWriteValue("iDotFm", "md5pass", m_md5pass);
        }

        public String User
        {
            get
            {
                return m_user;
            }
        }

        public String MD5Pass
        {
            get
            {
                return m_md5pass;
            }
        }
    }
}
