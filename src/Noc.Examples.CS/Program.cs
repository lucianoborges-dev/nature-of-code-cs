using Microsoft.Extensions.DependencyInjection;
using Noc.Examples.CS;
using Noc.Examples.CS.Ch01.Vectors.Noc101;
using Noc.Examples.CS.Ch01.Vectors.Noc102;
using Noc.Examples.CS.Ch01.Vectors.Noc103;
using Noc.Examples.CS.Ch01.Vectors.Noc104;
using Noc.Examples.CS.Ch01.Vectors.Noc105;
using Noc.Examples.CS.Ch01.Vectors.Noc106;
using Noc.Examples.CS.Ch01.Vectors.Noc107;
using Noc108 = Noc.Examples.CS.Ch01.Vectors.Noc108;
using Noc109 = Noc.Examples.CS.Ch01.Vectors.Noc109;
using Noc110 = Noc.Examples.CS.Ch01.Vectors.Noc110;
using Noc111 = Noc.Examples.CS.Ch01.Vectors.Noc111;

using Noc201 = Noc.Examples.CS.Ch02.Forces.Noc201;
using Noc202 = Noc.Examples.CS.Ch02.Forces.Noc202;
using Noc203 = Noc.Examples.CS.Ch02.Forces.Noc203;
using Noc204 = Noc.Examples.CS.Ch02.Forces.Noc204;

var serviceProvider = new ServiceCollection()
    .AddSingleton<MonogameSample>()
    .AddSingleton<BouncingBallNoVectors>()
    .AddSingleton<BouncingBallVectors>()
    .AddSingleton<BouncingBallVectorsObject>()
    .AddSingleton<VectorSubtraction>()
    .AddSingleton<VectorMultiplication>()
    .AddSingleton<VectorMagnitude>()
    .AddSingleton<VectorNormalize>()
    .AddSingleton<Motion101>()
    .AddSingleton<Noc108.Motion101Acceleration>()
    .AddSingleton<Noc109.Motion101Acceleration>()
    .AddSingleton<Noc110.Motion101Acceleration>()
    .AddSingleton<Noc111.Motion101AccelerationArray>()

    .AddSingleton<Noc201.Forces>()
    .AddSingleton<Noc202.Forces>()
    .AddSingleton<Noc203.Forces>()
    .AddSingleton<Noc204.ForcesFriction>()

    .BuildServiceProvider();

using var game = serviceProvider.GetRequiredService<Noc204.ForcesFriction>();
game.Run();



// Scrutor

//Assembly.GetExecutingAssembly()
//    .GetTypes()
//    .Where(a =>!a.IsAbstract && a.BaseType  == typeof(Sketch))
//    .Select(a => new { assignedType = a, serviceTypes = a.GetInterfaces().ToList() })
//    .ToList()
//    .ForEach(typesToRegister =>
//    {
//        typesToRegister.serviceTypes.ForEach(typeToRegister => services.AddScoped(typeToRegister, typesToRegister.assignedType));
//    });