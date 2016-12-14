﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Windows.ApplicationModel.Resources;

namespace MFDeploy.Utilities
{
    public abstract class Res
    {
        /// <summary>
        /// Gets a string from the platform resource file
        /// </summary>
        /// <param name="strTag">Tag name</param>
        /// <returns>localized string</returns>
        public static string GetString(string strTag)
        {
            string text = "";
            ResourceLoader res = ResourceLoader.GetForCurrentView();

            if (strTag == null)
            {
                return "";
            }

            try
            {
                text = res.GetString(strTag);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "";
            }
            return text;
        }
    }
}