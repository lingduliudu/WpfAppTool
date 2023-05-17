using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace WpfAppTool.src.effect
{
    internal class CanvasMove
    {
        private bool isDragging = false;
        private Point offset;

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            var rectangle = e.Source as UIElement;
            offset = e.GetPosition(rectangle);
            rectangle.CaptureMouse();
        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var rectangle = e.Source as UIElement;
            rectangle.ReleaseMouseCapture();
            isDragging = false;
        }

        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                var rectangle = e.Source as UIElement;
                Point position = e.GetPosition(myCanvas);
                double x = position.X - offset.X;
                double y = position.Y - offset.Y;
                Canvas.SetLeft(rectangle, x);
                Canvas.SetTop(rectangle, y);
            }
        }
    }
}
