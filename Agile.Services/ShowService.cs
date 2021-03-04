using Agile.Data;
using Agile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Services
{
    public class ShowService
    {

            private readonly Guid _userId;

            public ShowService(Guid showdId)
            {
                _userId = showdId;
            }


            public bool CreateShow(ShowCreate model)
            {
                var newShow =
                    new Show()
                    {
                        Title = model.Title,
                        Description = model.Description,
                        ReleaseDate = model.ReleaseDate,
                        CreaterID = _userId,
                        Season = model.Season,
                        Episode = model.Episode
                    };
                using (var context = new ApplicationDbContext())
                {
                    context.Shows.Add(newShow);
                    return context.SaveChanges() == 1;
                }
            }
        }
    }

