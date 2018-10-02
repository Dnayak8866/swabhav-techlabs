using MvcApp.Models.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp.Models.Services
{
    public class ColorService
    {
        List<ProColor> colorList = new List<ProColor>();

        public ColorService()
        {
            colorList.Add(new ProColor { Name="red",Code= "#FD0F07" });
            colorList.Add(new ProColor { Name="Green",Code= "#008000" });
            colorList.Add(new ProColor { Name="Blue",Code= "#0000FF" });
            
        }

        public string GetColorName(string code)
        {
            string colorname="";
            foreach (ProColor color in ColorList)
            {
                if (color.Code == code)
                {
                    colorname = color.Name;
                }
            }
            return colorname;
         
        }

        public List<ProColor> ColorList
        {
            get
            {
                return colorList;
            }
        }

        public int ColorCount
        {
            get
            {
                return colorList.Count;
            }
        }

    }
}