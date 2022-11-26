using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmptyViewTemplateDemo
{
    public class EmptyViewDataTemplateSelector : Microsoft.Maui.Controls.DataTemplateSelector
    {
        public DataTemplate BasicTemplate { get; set; }
        public DataTemplate AdvancedTemplate { get; set; }

        public EmptyViewDataTemplateSelector()
        {
         
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if(item.ToString().Count() > 10)
                return AdvancedTemplate;
            else
                return BasicTemplate;
        }
    }
}
