using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using OrderManagement.Model;

namespace OrderManagement.CustomMarkers
{
    public class GMapPolygonEx : GMapPolygon
    {
        public string orderId { get; set; }
        public GMapPolygonEx(List<PointLatLng> points, string name):base(points, name)
        {
           Stroke = new Pen(Brushes.Blue, 3);
        }

        public void IsSelected(ThematicTaskStatus status)
        {
            
            if (status==null)
            {
                Stroke = new Pen(Brushes.Red, 5);
            }
            else
            {
                if (status.TaskStatus == OrderStatus.生产中)
                {
                    Stroke = new Pen(Brushes.Yellow, 5);
                }else if (status.TaskStatus == OrderStatus.生产完成)
                {
                    Stroke = new Pen(Brushes.Green, 5);
                }else if (status.TaskStatus == OrderStatus.生产失败)
                {
                    Stroke = new Pen(Brushes.Red, 8);
                }
                else
                {
                    Stroke = new Pen(Brushes.Red, 5);
                }
            }                        
        }

        public void IsUnselected()
        {
            Stroke = new Pen(Brushes.Blue, 3);
        }

        

    }
}
