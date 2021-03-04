using Agile.Data;
using Agile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Services
{
    public class MovieService
    {
        private readonly Guid _userId;

        public MovieService(Guid modId)
        {
            _userId = modId;
        }


        public bool CreateMovie(MovieCreate model)
        {
            var entity =
                new Movie()
                {
                    Title = model.Title,
                    Description = model.Description,
                    ReleaseDate = model.ReleaseDate,
                    CreaterID = _userId
                };
            using (var context = new ApplicationDbContext())
            {
                context.Movies.Add(entity);
                return context.SaveChanges() == 1;
            }
        }
    }
}
