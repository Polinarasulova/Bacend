﻿using System;

interface ITunable
{
    void Tune();
}

abstract class Instrument
{
    public abstract void Play();
}

class Guitar : Instrument, ITunable
{
    public override void Play() => Console.WriteLine("Гитара ;erb!");

    public void Tune() => Console.WriteLine("Гитара настроена.");
}

class Piano : Instrument
{
    public override void Play() => Console.WriteLine("Фортепиано f,,f!");
}

class Program
{
    static void Main()
    {
        var guitar = new Guitar();
        guitar.Play();
        guitar.Tune();

        var piano = new Piano();
        piano.Play();
    }
}