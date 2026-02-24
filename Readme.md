# Support de cours — Principes SOLID (C#)

Ce dépôt contient des démonstrations pratiques des principes **SOLID** en C#.
L’objectif est de comprendre :

- le problème (code « Avant » ou « Problème »),
- la correction (code « Après » ou « Solution »),
- l’impact sur la maintenabilité.

---

## 1) S — Single Responsibility Principle (SRP)

**Définition :** une classe doit avoir une seule responsabilité, donc une seule raison de changer.

### Pourquoi ?

Quand une classe fait plusieurs choses (ex: accès données + logique métier + notification), elle devient difficile à tester, modifier et réutiliser.

### Dans ce dépôt

- Exemple principal : `Demo/DemoP/Exemple1`.
- Idée : séparer les responsabilités en petites classes spécialisées.

---

## 2) O — Open/Closed Principle (OCP)

**Définition :** les entités logicielles doivent être **ouvertes à l’extension** et **fermées à la modification**.

### Pourquoi ?

Quand on ajoute une nouvelle fonctionnalité, on préfère ajouter du nouveau code plutôt que modifier du code stable existant.

### Dans ce dépôt

- Exemple principal : `Demo/DemoO`.
- Structure pédagogique : comparer `Avant/Probleme` avec `Apres/Solution`.

---

## 3) L — Liskov Substitution Principle (LSP)

**Définition :** une classe dérivée doit pouvoir remplacer sa classe de base sans casser le comportement attendu.

### Pourquoi ?

Si un héritage introduit des exceptions inattendues ou des comportements incompatibles, le polymorphisme devient dangereux.

### Dans ce dépôt

- Exemples : `Demo/DemoL/Exemple1`, `Exemple2`, `Exemple3`, `Exemple4`.
- Objectif : montrer les cas où l’héritage est mal choisi, puis proposer une conception plus robuste.

---

## 4) I — Interface Segregation Principle (ISP)

**Définition :** il vaut mieux plusieurs interfaces spécifiques qu’une interface générale trop large.

### Pourquoi ?

Une classe ne doit pas être forcée d’implémenter des méthodes qu’elle n’utilise pas.

### Dans ce dépôt

- Exemple : `Demo/DemoI/Exemple1`.
- Comparaison directe entre `Avant` et `Apres`.

---

## 5) D — Dependency Inversion Principle (DIP)

**Définition :** les modules de haut niveau et bas niveau doivent dépendre d’abstractions, pas d’implémentations concrètes.

### Pourquoi ?

Le code devient plus flexible, testable (mock/stub), et facilement extensible (changement de provider, service, repository...).

### Dans ce dépôt

- Exemples : `Demo/DemoD/Exemple1` et `Demo/DemoD/Exemple2`.
- Focus : injection de dépendances, interfaces (`IRepository`, `IMessage`), variation des implémentations (GMail, Outlook...).

---

## Comment utiliser ce support

1. Ouvrir la solution `Demo/DemoSOLID.sln`.
2. Parcourir chaque projet (`DemoD`, `DemoI`, `DemoL`, `DemoO`, `DemoP`).
3. Lire d’abord le dossier `Avant`/`Probleme`.
4. Comparer ensuite avec `Apres`/`Solution`.
5. Exécuter les programmes (`Program.cs`) pour observer le comportement.

---

## Résumé rapide

- **S** : une classe = une responsabilité.
- **O** : étendre sans modifier l’existant.
- **L** : une sous-classe doit respecter le contrat de la classe mère.
- **I** : interfaces fines et ciblées.
- **D** : dépendre d’abstractions, pas de classes concrètes.

---

## Auteur

Support pédagogique pour l’apprentissage des principes SOLID en C#.
