<%@ Page Language="C#" %>
<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Analytics - Ext.NET Examples</title>
    <link href="/resources/css/examples.css" rel="stylesheet" type="text/css" />

    <script runat="server">
        public System.Drawing.Color ColorFromHSB(double h, double sl, double l)
        {
            double v;
            double r, g, b;

            r = l; 
            g = l;
            b = l;
            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);
            if (v > 0)
            {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = l + l - v;
                sv = (v - m) / v;
                h *= 6.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;
                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;
                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }
            return System.Drawing.Color.FromArgb(Convert.ToByte(r * 255.0f), Convert.ToByte(g * 255.0f), Convert.ToByte(b * 255.0f));
        }
    
        protected void Page_Load(object sender, EventArgs e)
        {
            var labels = new List<int>(31);
            for (int i = 1; i < 32; i++)
            {
                labels.Add(i);
            }

            var data = new List<int> { 8, 25, 27, 25, 54, 59, 79, 47, 27, 44, 44, 51, 56, 83, 12, 91, 52, 12, 40, 8, 60, 29, 7, 33, 56, 25, 1, 78, 70, 68, 2 };

            this.Draw(labels, data);
        }

        private void Draw(List<int> labels, List<int> data)
        {
            DrawComponent draw = this.Draw1;
            
            int width = 800;
            int height = 250;
            int leftgutter = 30;
            int bottomgutter = 20;
            int topgutter = 20;
            double colorhue = 0.6;
            string color = System.Drawing.ColorTranslator.ToHtml(this.ColorFromHSB(colorhue, 0.5, 0.5));

            double x = (width - leftgutter) / (labels.Count * 1.0);
            int max = data.Max();
            double y = (height - bottomgutter - topgutter) / (max*1.0);
            
            draw.Items.Add(this.GridPath(leftgutter + y * 0.5 + 0.5, topgutter + 0.5, width - leftgutter - x, height - topgutter - bottomgutter, 10, 10, "#000"));
            
            var pathSprite = new Sprite {
                Type = SpriteType.Path,     
                Stroke = color,          
                StrokeWidth = 4,
                StrokeLinejoin = StrokeLinejoin.Round
            };
            draw.Items.Add(pathSprite);
            
            var bgpSprite = new Sprite{
                Type = SpriteType.Path,     
                Stroke = "none",          
                Opacity = 0.3,
                Fill = color
            };
            
            draw.Items.Add(bgpSprite);            
            
            var p = new List<string>();
            var bgpp = new List<string>();
            
            for (int i = 0; i < labels.Count; i++)
			{
                var yc = Convert.ToInt32(Math.Round(height - bottomgutter - y * data[i]));
                var xc = Convert.ToInt32(Math.Round(leftgutter - 10 + x * (i + 0.5)));
                var heightCraph = height - bottomgutter;
                draw.Items.Add(new Sprite{
                     Type = SpriteType.Text,
                     X = Convert.ToInt32(xc),
                     Y = height - 6,
                     Text = labels[i].ToString(),   
                     Fill = "#000",
                     Font = "12px Helvetica, Arial"
                });
                
                if(i == 0)
                {
                    p.AddRange(new string[]{"M", JSON.Serialize(xc), JSON.Serialize(yc), 
                                            "C", JSON.Serialize(xc), JSON.Serialize(yc)});

                    bgpp.AddRange(new string[]{"M", JSON.Serialize(leftgutter - 10 + x * 0.5), JSON.Serialize(height - bottomgutter), 
                                               "L", JSON.Serialize(xc), JSON.Serialize(yc), 
                                               "C", JSON.Serialize(xc), JSON.Serialize(yc)});
                }
                
                if(i > 0 && i < (labels.Count - 1))
                {
                    var Y0 = Math.Round(height - bottomgutter - y * data[i - 1]);
                    var X0 = Math.Round(leftgutter + x * (i - 0.5));
                    var Y2 = Math.Round(height - bottomgutter - y * data[i + 1]);
                    var X2 = Math.Round(leftgutter + x * (i + 1.5));
                    var a = this.GetAnchors(X0, Y0, xc, yc, X2, Y2);
                    
                    p.AddRange(new string[]{JSON.Serialize(a[0]), JSON.Serialize(a[1]), JSON.Serialize(xc), JSON.Serialize(yc), JSON.Serialize(a[2]), JSON.Serialize(a[3])});
                    bgpp.AddRange(new string[]{JSON.Serialize(a[0]), JSON.Serialize(a[1]), JSON.Serialize(xc), JSON.Serialize(yc), JSON.Serialize(a[2]), JSON.Serialize(a[3])});
                }
                
                draw.Items.Add(new Sprite{
                    SpriteID = "dot_"+i,
                    Type = SpriteType.Circle,
                    X = Convert.ToInt32(xc),
                    Y = Convert.ToInt32(yc),
                    Radius = 4,
                    Fill = "#333",
                    Stroke = color,
                    StrokeWidth = 2
                });

                var rect = new Sprite
                {
                    Type = SpriteType.Rect,
                    X = Convert.ToInt32(leftgutter + x * i),
                    Y = 0,
                    Width = Convert.ToInt32(xc),
                    Height = heightCraph,
                    Stroke = "none",
                    Fill = "#fff",
                    Opacity = 0
                };

                rect.Listeners.MouseOver.Handler = string.Format("onMouseOver(this, {0}, {1}, {2});", data[i], labels[i], i);
                rect.Listeners.MouseOut.Handler = string.Format("onMouseOut(this, {0});", i);
                
                draw.Items.Add(rect);
                
                if(i == (labels.Count -1))
                {
                    p.AddRange(new string[]{JSON.Serialize(xc), JSON.Serialize(yc), JSON.Serialize(xc), JSON.Serialize(yc)});
                    bgpp.AddRange(new string[]{JSON.Serialize(xc), JSON.Serialize(yc), JSON.Serialize(xc), JSON.Serialize(yc), "L", JSON.Serialize(xc), JSON.Serialize(height - bottomgutter), "z"});
                    pathSprite.Path = string.Join(" ", p);
                    bgpSprite.Path = string.Join(" ", bgpp);
                }
			}   
            
            draw.Width = width;
            draw.Height = height;
        }
        
        private double[] GetAnchors(double p1x, double p1y, double p2x, double p2y, double p3x, double p3y) {
            var l1 = (p2x - p1x) / 2;
            var l2 = (p3x - p2x) / 2;
            var a = Math.Atan((p2x - p1x) / Math.Abs(p2y - p1y));
            var b = Math.Atan((p3x - p2x) / Math.Abs(p2y - p3y));
            
            a = p1y < p2y ? Math.PI - a : a;
            b = p3y < p2y ? Math.PI - b : b;
            
            var alpha = Math.PI / 2 - ((a + b) % (Math.PI * 2)) / 2;
            var dx1 = l1 * Math.Sin(alpha + a);
            var dy1 = l1 * Math.Cos(alpha + a);
            var dx2 = l2 * Math.Sin(alpha + b);
            var dy2 = l2 * Math.Cos(alpha + b);
            
            return new double[]{
                p2x - dx1,
                p2y + dy1,
                p2x + dx2,
                p2y + dy2
            };
        }

        private Sprite GridPath(double x, double y, double w, double h, int wv, int hv, string color)
        {
            var path = new List<string>{"M", JSON.Serialize(Math.Round(x) + 0.5), JSON.Serialize(Math.Round(y) + 0.5), 
                                        "L", JSON.Serialize(Math.Round(x + w) + 0.5), JSON.Serialize(Math.Round(y) + 0.5), 
                                         JSON.Serialize(Math.Round(x + w) + 0.5), JSON.Serialize(Math.Round(y + h) + 0.5), 
                                         JSON.Serialize(Math.Round(x) + 0.5), JSON.Serialize(Math.Round(y + h) + 0.5), 
                                         JSON.Serialize(Math.Round(x) + 0.5), JSON.Serialize(Math.Round(y) + 0.5)};
            
            var rowHeight = h / hv;
            var columnWidth = w / wv;
            
            for (int i = 1; i < hv; i++) {
                path.AddRange(new string[]{"M", JSON.Serialize(Math.Round(x) + 0.5), JSON.Serialize(Math.Round(y + i * rowHeight) + 0.5), 
                                                        "H", JSON.Serialize(Math.Round(x + w) + 0.5)});                
            }
            
            for (int i = 1; i < wv; i++) {
                path.AddRange(new string[]{"M", JSON.Serialize(Math.Round(x + i * columnWidth) + 0.5), JSON.Serialize(Math.Round(y) + 0.5), 
                                                        "V", JSON.Serialize(Math.Round(y + h) + 0.5)});
            }
            
            return new Sprite{
                Type = SpriteType.Path,     
                Stroke = color,          
                Path = String.Join<string>(" ", path)
            };  
        }
    </script>

    <script type="text/javascript">
        var leave_timer;
        function onMouseOver(sprite, data, label, i){
           var dot = sprite.surface.items.get("dot_"+i),
               tip = App.DotTooltip;
           dot.setAttributes({radius:6}, true);

           clearTimeout(leave_timer);

           //tip.data = {label:label, value:data};          
           var xy = dot.el.getXY();
           xy[0] = xy[0] + 20;
           xy[1] = xy[1] - 5;
           tip.setTitle(data + ' hits'); 
           tip.update(label + ' January 2012');
           tip.showAt(xy);
        }

        function onMouseOut(sprite, i){
           var dot = sprite.surface.items.get("dot_"+i);
           dot.setAttributes({radius:4}, true);

           leave_timer = setTimeout(function () {
               App.DotTooltip.hide();
           }, 500);
        }
    </script>
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />

        <ext:Viewport runat="server">
            <LayoutConfig>
                <ext:VBoxLayoutConfig Align="Center" Pack="Center" />
            </LayoutConfig>
            <Items>
                <ext:DrawComponent ID="Draw1" runat="server" ViewBox="false" />
            </Items>
        </ext:Viewport>   

        <ext:ToolTip 
            ID="DotTooltip"
            runat="server"    
            Anchor="left"        
            Title="&#160;">            
        </ext:ToolTip>    
    </form>    
</body>
</html>
