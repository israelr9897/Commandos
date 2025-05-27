
# 🪖 Commandos Simulation

This is a C# console application that simulates different types of commandos (ground, air, and sea) with unique behaviors and actions.

---

## 📁 Project Structure

- `Commando.cs` – Base class representing a general commando (not included in the uploaded files).
- `AirCommando.cs` – Derived class for an air commando (not included in the uploaded files).
- `SeaCommando.cs` – Derived class for a sea commando, includes a custom `Swimming` method.
- `Program.cs` – Entry point that creates instances of different commando types and executes actions.

---

## 🚀 How to Run

1. Open the project in Visual Studio or any C# IDE.
2. Make sure all class files (`Commando.cs`, `AirCommando.cs`, `SeaCommando.cs`, `Program.cs`) are in the same namespace or properly referenced.
3. Build the solution.
4. Run the application.

---

## 🧠 How It Works

- The `Main` method creates an array of commandos: one general, one air, and one sea.
- Each commando has a `codeName`, `name`, and a list of `tools`.
- The `Attack()` method is called on each commando.
- The `SeaCommando` class includes an extra method `Swimming()` for custom behavior, although it is not called in `Main`.

---

## 📌 Example Output

```
SeaCommando with codename s is active.
```

*Note: Only the `Attack()` method is used in `Main`, so output reflects that behavior.*

---

## 📎 Requirements

- .NET 6.0 SDK or later
- C# compiler

---

## 📬 Contact

For improvements or issues, feel free to open a pull request or submit an issue.
