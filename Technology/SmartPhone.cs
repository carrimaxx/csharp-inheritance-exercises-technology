using System;
using System.Collections.Generic;
using System.Text;


namespace Technology
{
    public class SmartPhone : Computer
    {
        public bool IsWaterproof { get; set; }
        public double CameraInPixels { get; set; }

        public SmartPhone(int ram, int capacity, string manufacturer, bool isWaterproof, double cameraInPixels) : base(ram, capacity, manufacturer)
        {
            IsWaterproof = isWaterproof;
            CameraInPixels = cameraInPixels;
        }

        
    }
}
