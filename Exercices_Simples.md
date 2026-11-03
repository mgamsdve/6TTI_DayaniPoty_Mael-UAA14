# POO : exercices simples

La solution `Exercices_Simples_DPMAEL.sln` regroupe les deux projets console.
Chaque dossier contient le code C#, son programme de test et son diagramme UML
éditable avec diagrams.net.

## Exercice 1 : véhicules

Dossier : `6TTI_Vehicule_DPMAEL`.

- `Vehicule.cs` : classe du véhicule.
- `Program.cs` : tableau `garage` et tests.
- `Vehicule.drawio` : diagramme UML.

La capacité du réservoir est en litres entiers. Le niveau et les ajouts peuvent
contenir des décimales. Le niveau peut être modifié pour représenter le carburant
consommé, mais il doit rester entre zéro et la capacité du réservoir.
Un ajout négatif, nul ou trop grand est refusé.

Le programme utilise deux véhicules. Il affiche leurs informations, ajoute
10 litres, retire 5 litres avec la propriété, puis fait le plein.
Il vérifie aussi que les valeurs incorrectes ne modifient pas le niveau.

## Exercice 2 : entraînements

Dossier : `6TTI_Entrainement_DPMAEL`.

- `Entrainement.cs` : classe de l'entraînement.
- `Program.cs` : tableau des entraînements et affichage des résultats.
- `Entrainement.drawio` : diagramme UML.

Le nom contient le prénom et le nom du coureur. La distance est en kilomètres
et la durée est un `TimeSpan`. La vitesse moyenne se calcule en divisant la
distance par la durée en heures (`TotalHours`).

Les trois coureurs parcourent 5 km. Le meilleur temps choisi est de
1200 secondes, soit 20 minutes. L'écart correspond au temps du coureur moins
le meilleur temps. Un écart positif indique un retard, zéro indique le même
temps et un écart négatif indique un temps plus rapide.

Résultats attendus :

| Participant | Durée | Vitesse moyenne | Retard |
| --- | --- | --- | --- |
| Mael Dayani Poty | 25 min | 12 km/h | 300 s |
| Lucas Martin | 30 min | 10 km/h | 600 s |
| Emma Laurent | 22 min 30 s | 13,33 km/h | 150 s |

## Lancer les programmes

Depuis le dossier contenant la solution :

```sh
dotnet build Exercices_Simples_DPMAEL.sln
dotnet run --project 6TTI_Vehicule_DPMAEL
dotnet run --project 6TTI_Entrainement_DPMAEL
```

Dans un IDE, ouvrir la solution et choisir le projet à exécuter.
