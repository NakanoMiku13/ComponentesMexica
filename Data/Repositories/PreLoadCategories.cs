using ComponentesMexica.Data.Models;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class PreLoadCategories
    {
        public void PreLoadData(ApplicationDbContext context)
        {
            var Category1 = new Category()
            {
                Name="Mobo"
            };
            var Category2 = new Category()
            {
                Name ="GPU"
            };
            var Category3 = new Category()
            {
                Name ="CPU"
            };
            var Category4 = new Category()
            {
                Name ="RAM"
            };
            var Category5 = new Category()
            {
                Name ="Case"
            };
            var Category6 = new Category()
            {
                Name ="HDD"
            };
            var Category7 = new Category()
            {
                Name ="PSU"
            };
            var Category8 = new Category()
            {
                Name = "Software"
            };
            var Category9 = new Category()
            {
                Name = "Cooler"
            };
            context.Add(Category1);
            context.Add(Category2);
            context.Add(Category3);
            context.Add(Category4);
            context.Add(Category5);
            context.Add(Category6);
            context.Add(Category7);
            context.Add(Category8);
            context.Add(Category9);
            context.SaveChanges();
        }
    }
}
