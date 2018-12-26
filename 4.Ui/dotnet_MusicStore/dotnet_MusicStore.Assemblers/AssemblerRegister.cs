using Autofac;

namespace dotnet_MusicStore.Assemblers
{
    public static class AssemblerRegister
    {
        public static void RegistAssembler(this ContainerBuilder builder)
        {
            builder.RegisterType<MusicAssembler>().AsImplementedInterfaces();
            builder.RegisterType<UserAssembler>().AsImplementedInterfaces();
        }
    }
}
