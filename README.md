
# 🪖 Commandos Game

This project simulates a modular game system of different types of commandos, weapons, and enemies. The code is written in C# and demonstrates object-oriented programming (OOP) principles, design patterns, inheritance, and interfaces.

---

## 🔧 Project Structure

The system is built from several main components:

### 🧍 Commandos
- `Commando` – Base class for a soldier, includes name, code name, tools, status, and type.
- `AirCommando` – Inherits from Commando, adds parachuting behavior.
- `SeaCommando` – Inherits from Commando, adds swimming behavior.
- `CommandoFactory` – Generates commandos of various types.

### 👹 Enemies
- `Enemy` – Base class with name, health, and life status.
- `EnemyArmed` – Armed enemy holding a weapon (inherits from Enemy).
- `EnemyZombi` – Zombie enemy with special power.
- `EnemyFactory` – Generates enemies of different types.

### 🔫 Weapons
- `WeaponShoot` – Base class for weapons with name, manufacturer, and bullet count.
- `M16`, `AK47` – Inherit from WeaponShoot with different behavior.
- `IShootable` – Interface requiring shoot-related actions.
- `WeaponFactory` – Creates weapons based on type.

### 🎮 Game Engine
- `Game` – Initializes the game with random commandos, enemies, and weapons.
- `Program` – Main file that runs the simulation and prints commando data.

---

## 🧪 Sample Usage

```csharp
Game.InitGame(10, 10, 10); // Initialize game with 10 commandos, 10 weapons, 10 enemies

foreach (var item in CommandoFactory.CommandoObjList)
{
    item.SayName("GENERAL");
    Console.WriteLine(item.Type);
}
```

---

## 🏗️ Implemented Concepts

- **Inheritance** – e.g., `Commando` → `AirCommando`
- **Polymorphism** – Each class implements its own behavior
- **Interfaces** – e.g., `IShootable` for flexible design
- **Singleton Pattern** – Implemented in the `Game` class

---

## 📁 Suggested Folder Structure

```
/Commandos
│
├── Models/
│   ├── Commando.cs
│   ├── AirCommando.cs
│   ├── SeaCommando.cs
│   ├── Enemy.cs
│   ├── EnemyArmed.cs
│   ├── EnemyZombi.cs
│   ├── WeaponShoot.cs
│   ├── AK47.cs
│   ├── M16.cs
│   ├── Interfaces/
│   │   ├── IShootable.cs
│   │   ├── IBreakable.cs
│
├── Factories/
│   ├── CommandoFactory.cs
│   ├── EnemyFactory.cs
│   ├── WeaponFactory.cs
│
├── Game.cs
├── Program.cs
```

---

## 📌 Requirements

- .NET Core / .NET Framework (latest version)
- IDE: Visual Studio / Rider / VS Code
