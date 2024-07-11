# Acquario-WPF
Il progetto nasce come studio della programmazione ad oggetti (OOP) attraverso il linguaggio C#.  
Questo applicativo WPF (Windows Presentation Foundation) ha solo funzionalità visiva, infatti l'obiettivo è emulare i vecchi screensaver presenti nelle versioni di Microsoft Windows 95 / Vista.

Questo progetto è stato realizzato a fini didattici durante il corso di studio ITS FITSTIC "Alan Turing" di Cesena, A.A. 2020/2021

## Gerarichia oggetti nell'acquario

Partendo dal concetto macroscopico dell'**OggettoMarino** che accomuna tutti gli elementi presenti nell'acquario, si ereditano due grandi oggetti in base alla loro caratteristica: **OggettoMarinoInanimato** e **OggettoMarinoAnimato**.  
Questi, come esplicita il nome, si dividono per il loro comportamento a video.  

A seguire la lista completa degli oggetti suddivisa per ereditarietà.
```
OggettoMarino
├── OggettoMarinoInanimato
│   ├── Forziere
│   ├── Conchiglia
│   └── Bandiera
└── OggettoMarinoAnimato
    ├── Sommozzatore
    ├── PesceRosso
    ├── PescePagliaccio
    ├── PesceAngelo
    ├── PesceBetta
    ├── Granchio
    └── Bolle
```

## Logica e flusso elementi a video

![acquario](images/docs/acquario.gif)