using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OrderManagement.CustomMarkers
{
    public class GMapPolygonEx : GMapPolygon
    {
        public string orderId { get; set; }
        public GMapPolygonEx(List<PointLatLng> points, string name):base(points, name)
        {
           Stroke = new Pen(Brushes.Blue, 3);
        }

        public void IsSelected()
        {
            Stroke = new Pen(Brushes.Red, 5);
        }

        public void IsUnselected()
        {
            Stroke = new Pen(Brushes.Blue, 3);
        }

        

    }
}
