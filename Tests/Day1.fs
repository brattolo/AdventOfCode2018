module Day1

open System
open NUnit.Framework
open Day1Program

[<Test>]
let ``Frequence of 0 changes with +1 results in 1``() =
    let frequencyStart = 0
    let frequencyChange = 1

    let expected = 1

    let result = Day1Program.applyFrequencyChange frequencyStart frequencyChange
    Assert.AreEqual(expected, result)

[<Test>]
let ``Frequence of 1 changes with -2 results in -1``() =
    let frequencyStart = 1
    let frequencyChange = -2

    let expected = -1

    let result = Day1Program.applyFrequencyChange frequencyStart frequencyChange
    Assert.AreEqual(expected, result)

[<Test>]
let ``Frequence of -1 changes with +3 results in 2``() =
    let frequencyStart = -1
    let frequencyChange = +3

    let expected = 2

    let result = Day1Program.applyFrequencyChange frequencyStart frequencyChange
    Assert.AreEqual(expected, result)

[<Test>]
let ``Frequence of 2 changes with +1 results in 3``() =
    let frequencyStart = 2
    let frequencyChange = 1

    let expected = 3

    let result = Day1Program.applyFrequencyChange frequencyStart frequencyChange
    Assert.AreEqual(expected, result)

[<Test>]
let ``Frequency changes with +1 and -6 results in -1``() =
    let frequencyStart = 4
    let frequencyChange = [1; -6]

    let expected = -1

    let result = Day1Program.calculateFrequencyChanges frequencyStart frequencyChange
    Assert.AreEqual(expected, result)