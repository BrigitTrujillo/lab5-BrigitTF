using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


namespace lab05
{
    [Preserve(AllMembers = true)]
    [ContentProperty(nameof(Source))]

    public class Image : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null) 
                return null;

            var imageSource = ImageSource.FromResource(Source,
                typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }

}