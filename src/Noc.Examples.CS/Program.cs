using Microsoft.Xna.Framework;
using Chapter1 = Noc.Examples.CS.Ch01;
using Chapter2 = Noc.Examples.CS.Ch02;

static void RunExample(string sample)
{
    Game game = sample switch
    {
        // Chapter 1
        "Noc101" => new Chapter1.Vectors.Noc101.BouncingBallNoVectors(),
        "Noc102" => new Chapter1.Vectors.Noc102.BouncingBallVectors(),
        "Noc103" => new Chapter1.Vectors.Noc103.VectorSubtraction(),
        "Noc104" => new Chapter1.Vectors.Noc104.VectorMultiplication(),
        "Noc105" => new Chapter1.Vectors.Noc105.VectorMagnitude(),
        "Noc106" => new Chapter1.Vectors.Noc106.VectorNormalize(),
        "Noc107" => new Chapter1.Vectors.Noc107.Motion101(),
        "Noc108" => new Chapter1.Vectors.Noc108.Motion101Acceleration(),
        "Noc109" => new Chapter1.Vectors.Noc109.Motion101Acceleration(),
        "Noc110" => new Chapter1.Vectors.Noc110.Motion101Acceleration(),
        "Noc111" => new Chapter1.Vectors.Noc111.Motion101AccelerationArray(),

        // Chapter 2
        "Noc201" => new Chapter2.Forces.Noc201.Forces(),
        "Noc202" => new Chapter2.Forces.Noc202.Forces(),
        "Noc203" => new Chapter2.Forces.Noc203.Forces(),
        "Noc204" => new Chapter2.Forces.Noc204.ForcesFriction(),
        "Noc205" => new Chapter2.Forces.Noc205.ForcesDrag(),
        "Noc206" => new Chapter2.Forces.Noc206.Attraction(),
        "Noc207" => new Chapter2.Forces.Noc207.AttractionMany(),
        "Noc208" => new Chapter2.Forces.Noc208.MutualAttraction(),

        // A basic Monogame sample
        _ => new Noc.Examples.CS.MonogameSample()
    };

    game.Run();
}

// Run the example
RunExample("Noc205");