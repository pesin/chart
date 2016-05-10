namespace chart.lib.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<chart.lib.DataModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(chart.lib.DataModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //



            Chart c = new Chart()
            {
                ID = 1,
                Name = "No.1",
                Description = "testing chart aidez seed wishbone"
            };

            int i;

            var r1 = new ChartRow()
            {
                ID = 1,
                Side = Side.RS
            };

            r1.Cells.Add(new ChartCell()
            {
                Id = 2,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 1,
                Stitch = Stitch.Purl
            });

            for (i = 0; i < 8; i++)
            {
                r1.Cells.Add(new ChartCell()
                {
                    Id = i + 3,
                    Stitch = Stitch.Cable8_slip2b_k1_p1slip_k1slip_p1slip_slip1f_k1p1k1_k1slip
                });

            }
            r1.Cells.Add(new ChartCell()
            {
                Id = 11,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 12,
                Stitch = Stitch.Purl
            });

            c.Rows.Add(r1);

            //row 2
            r1 = new ChartRow()
            {
                ID = 2,
                Side = Side.WS
            };
            r1.Cells.Add(new ChartCell()
            {
                Id = 1,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 2,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 3,
                Stitch = Stitch.Knit
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 4,
                Stitch = Stitch.Knit
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 5,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 6,
                Stitch = Stitch.Knit
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 7,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 8,
                Stitch = Stitch.Knit
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 9,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 10,
                Stitch = Stitch.Knit
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 11,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 12,
                Stitch = Stitch.Purl
            });


            //row 3
            r1 = new ChartRow()
            {
                ID = 3,
                Side = Side.RS
            };
            r1.Cells.Add(new ChartCell()
            {
                Id = 1,
                Stitch = Stitch.Purl
            });
            r1.Cells.Add(new ChartCell()
            {
                Id = 2,
                Stitch = Stitch.Purl
            });
        }
    }
}
