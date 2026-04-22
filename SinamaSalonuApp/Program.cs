using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SinamaApp.Business.Abstract;
using SinamaApp.Business.Concrete;
using SinamaApp.DataAccessLayer.Abstract;
using SinamaApp.DataAccessLayer.Concrete.EFCore;
using SinamaApp.Entities.Concrete;


namespace SinamaSalonuApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            loadingForm.Refresh();
            var timer = System.Diagnostics.Stopwatch.StartNew();

            ServiceCollection services = new();
            services.AddTransient<Form1>();
            services.AddTransient<ucAddFilm>();
            services.AddTransient<ucList>();
            services.AddTransient<ucSeansList>();
            services.AddTransient<ucBiletAl>();
            services.AddTransient<ucKasa>();
            services.AddTransient<ucLogin>();
            services.AddTransient<ucRegister>();
            services.AddTransient<ucUpdateFilm>();
            services.AddTransient<ucDeleteFilm>();
            services.AddTransient<ucSeansAdd>();
            services.AddTransient<ucSessionDelete>();
            services.AddTransient<ucSessionUpdate>();
            services.AddTransient<ucActorAdd>();
            services.AddTransient<ucActorDelete>();
            services.AddTransient<ucActorUpdate>();
            services.AddTransient<ucDirectorAdd>();
            services.AddTransient<ucDirectorUpdate>();
            services.AddTransient<ucDirectorDelete>();
            services.AddDbContextFactory<SinamaAppDbContext>(options => 
                options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=SinamaSalonuAppDB;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddScoped<IFilmDAL, EfFilmDAL>();
            services.AddScoped<IYonetmenDAL, EfYonetmenDAL>();
            services.AddScoped<ISeansDAL, EfSeansDAL>();
            services.AddScoped<ISalonDAL, EfSalonDAL>();
            services.AddScoped<IKoltukDAL, EfKoltukDAL>();
            services.AddScoped<IBiletDAL, EfBiletDAL>();
            services.AddScoped<IKategoriDAL, EfKategoriDAL>();
            services.AddScoped<IOyuncuDAL, EfOyuncuDAL>();
            services.AddScoped<IKullaniciDAL, EfKullaniciDAL>();
            services.AddScoped<IYonetmenService, YonetmenManager>();
            services.AddScoped<IFilmService, FilmManager>();
            services.AddScoped<ISeansService, SeansManager>();
            services.AddScoped<ISalonService, SalonManager>();
            services.AddScoped<IBiletService, BiletManager>();
            services.AddScoped<IKullaniciService, KullaniciManager>();
            services.AddScoped<IKategoriService, KategoriManager>();
            services.AddScoped<IOyuncuService, OyuncuManager>();
            services.AddScoped<IKoltukService, KoltukManager>();
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IEntityRepository<>), typeof(EfEntityRepositoryBase<>));
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<Form1>();

                timer.Stop();
                int remainingTime = 3000 - (int)timer.ElapsedMilliseconds;

                DateTime end = DateTime.Now.AddMilliseconds(remainingTime);
                while (DateTime.Now < end)
                {
                    Application.DoEvents();
                    Thread.Sleep(10);       
                }
                loadingForm.Close();
                Application.Run(mainForm);
            }
        }
    }
}