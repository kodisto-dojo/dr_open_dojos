let filename = "tickets.dat"
use file = new System.IO.StreamReader(filename)

let names = 
Seq.initInfinite(fun i -> 
file.ReadLine()
)
|> Seq.takeWhile (System.String.IsNullOrEmpty >> not)
|> Seq.map (fun line -> 
line.Split('=')
)
|> Seq.map (fun stringArray -> 
(stringArray.[0], System.Int32.Parse(stringArray.[1]))
)
|> Seq.collect (fun (name, count) -> 
seq {
for i=0 to count do yield name
}
)
|> List.ofSeq

let random = new System.Random()
let winner: int = random.Next(1, names.Length)
System.Console.WriteLine ("El ganador es: " + names.[winner])