using RemoteDesktopManager.Data;
using System.Data.Entity.Migrations;
using RemoteDesktopManager.Helpers;
using RemoteDesktopManager.Models;

namespace RemoteDesktopManager.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.RemoteDisplayColors.AddOrUpdate(new RemoteDisplayColor(DisplayColor._8bits));
            context.RemoteDisplayColors.AddOrUpdate(new RemoteDisplayColor(DisplayColor._15bits));
            context.RemoteDisplayColors.AddOrUpdate(new RemoteDisplayColor(DisplayColor._16bits));
            context.RemoteDisplayColors.AddOrUpdate(new RemoteDisplayColor(DisplayColor._24bits));
            context.RemoteDisplayColors.AddOrUpdate(new RemoteDisplayColor(DisplayColor._32bits));

            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize {Id = ScreenSize.Default.ToLong(), Width = 800, Height = 600, Title = "Default"});
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize {Id = ScreenSize.Fullscreen.ToLong(), Title = "Fullscreen"});
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W640_H480));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W800_H600));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1024_H768));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1152_H864));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1280_H800));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1440_H900));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1400_H1050));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1600_H1024));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1600_H1200));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1600_H1280));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1680_H1050));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1900_H1200));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W1920_H1200));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W2048_H1536));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W2560_H2048));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W3200_H2400));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize(ScreenSize.W3840_H2400));
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize {Id = ScreenSize.Custom.ToLong(), Title = "Custom"});
            context.ScreenSizes.AddOrUpdate(new RemoteScreenSize {Id = ScreenSize.CurrentScreenSize.ToLong(), Title = "Current screen size"});
        }
    }
}