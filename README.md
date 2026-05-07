
<img width="1408" height="768" alt="image" src="https://github.com/user-attachments/assets/a1876595-9060-4d44-a773-0d2d569cfd8f" />

<div align="center">

A gamified academic productivity desktop application built with C# and Windows Forms.
Turn your study tasks into quests — earn XP, level up, unlock avatars, collect badges, and rise on the leaderboard.


![Platform](https://img.shields.io/badge/Platform-Windows-blue?style=flat-square&logo=windows)
![Language](https://img.shields.io/badge/Language-C%23-purple?style=flat-square&logo=csharp)
![Framework](https://img.shields.io/badge/Framework-.NET%206.0-blueviolet?style=flat-square&logo=dotnet)
![UI](https://img.shields.io/badge/UI-Windows%20Forms-informational?style=flat-square)
![Status](https://img.shields.io/badge/Status-Active-success?style=flat-square)

</div>

---

## 📑 Table of Contents

- 📖 [Project Description and Purpose](#-project-description-and-purpose)
- 🗂️ [UML Diagram](#️-uml-diagram)
- ✨ [Features and Functionalities](#-features-and-functionalities)
- 🏗️ [System Architecture](#-system-architecture)
- ⚙️ [How the Program Works](#️-how-the-program-works)
- 💾 [Data Persistence](#-data-persistence)
- 🚀 [How to Run the Application](#-how-to-run-the-application)
- 📁 [Project Structure](#-project-structure)
- 👨‍💻 [Developers](#-developers--team-members)

---

## 📖 Project Description and Purpose

StudyQuest is a desktop productivity application developed in *C# using Windows Forms* that applies game design principles — commonly known as gamification — to academic task management. It is designed specifically for students who struggle with procrastination, lack of motivation, or difficulty maintaining consistent study habits.

### Problem Statement

Students often find it difficult to stay motivated when managing academic tasks such as assignments, projects, and study sessions. Traditional to-do list applications lack the engaging feedback loops that keep users returning and committed to their goals.

### Solution

StudyQuest reimagines the study experience as a role-playing game (RPG). Each task completed rewards the student with *Experience Points (XP)*, contributing to character *level progression*. Missing a deadline incurs an *XP penalty*, reinforcing accountability. The application further motivates engagement through an *avatar customization shop*, a *badge achievement system*, a *weekly leaderboard*, and a *daily streak tracker* — all proven mechanics from game design that drive habitual behavior.

### Goals

- Increase student motivation and task completion rates
- Build consistent daily study habits through streak rewards
- Provide a visual sense of progress through leveling and achievements
- Make academic productivity enjoyable and interactive

---

## 🗂️ UML Diagram
<img width="3665" height="2130" alt=" UML Diagran" src="https://github.com/user-attachments/assets/5ef50e6c-ecb9-400b-9c2d-c72da2abb5df" />



---

## ✨ Features and Functionalities

### 🔐 1. Authentication System (login_ui)

The login screen is the application's entry point and includes security mechanisms to prevent unauthorized access.

| Feature | Details |
|---|---|
| Credential Validation | Checks username and password against stored values |
| Password Masking | Password field uses UseSystemPasswordChar by default |
| Toggle Visibility | Inline 👁 button toggles password display on/off |
| Failed Attempt Tracking | Counts consecutive failed login attempts |
| Account Lockout | After *3 failed attempts*, the login is disabled for *30 seconds* |
| Lockout Countdown | Button displays remaining lockout time (e.g., Wait 27s...) |
| Auto-Recovery | Login re-enables automatically after the lockout period expires |

---

### 📋 2. Task Management (sidebar_task)

The task panel is the core of StudyQuest. It is implemented as a *Singleton* to ensure task and XP data persists across navigation within a session.

***Adding Tasks***
- Enter a task title (required), optional details, and a deadline date
- Deadline must not be in the past
- Difficulty is *automatically determined* based on days remaining:

| Difficulty | Days Until Deadline | XP Reward |
|---|---|---|
| 🟢 Easy | More than 5 days | +20 XP |
| 🟡 Medium | 3 to 5 days | +30 XP |
| 🔴 Hard | Fewer than 3 days | +50 XP |

***Task Actions***
- *Complete* — Select a task and mark it done to claim XP. Triggers a streak update.
- *Delete* — Remove any task with a confirmation dialog.
- *Double-click* — View full task details (title, description, deadline, difficulty, status).

***Deadline Enforcement***
- A background timer runs every *60 seconds* to check for overdue tasks
- Any pending task past its deadline is automatically marked as *MISSED*
- Each missed task deducts *-10 XP* as a penalty
- Tasks reclassify themselves (e.g., Easy → Hard) as deadlines approach

---

### 🏆 3. XP & Leveling System

The progression system gives students a long-term goal to work toward.

*XP Earning & Spending*
- XP is earned by completing tasks based on difficulty
- XP can be spent in the *Avatar Shop* to unlock cosmetic items
- Spending XP does not affect TotalEarnedEXP, only CurrentEXP

*Level Thresholds*

| Level | Cumulative XP Required |
|---|---|
| Level 1 → 2 | 200 XP |
| Level 2 → 3 | 300 XP |
| Level N → N+1 | 200 + (N-1) × 100 XP |
| *Max Level* | *Level 100* |

- A level-up notification appears each time a threshold is crossed
- Upon reaching Level 100, a special *MAX LEVEL* achievement message is shown
- The sidebar displays the current level, a progress bar, and completion percentage toward the next level

---

### 🏅 4. Badge Achievement System (sidebar_badges)

StudyQuest features *8 unlockable badges* that are automatically awarded when conditions are met. Badges update in real-time whenever XP changes.

| # | Badge Name | Unlock Condition |
|---|---|---|
| 1 | 🌱 First Task? Yey! | Complete at least 1 task |
| 2 | 📅 Cant Stop Me! | Maintain a 3-day streak |
| 3 | 🔥 Im On Fire! | Maintain a 7-day streak |
| 4 | ⚡ Cant Stop Me! | Maintain a 15-day streak |
| 5 | 💎 Just Starting... | Accumulate 100 total XP |
| 6 | 👑 Do I Know Everything Now? | Accumulate 1,000 or Above total XP |
| 7 | 🚀 MaSTER That's Me | Reach Level 5 |
| 8 | 🏆 Legendary!!! | Reach Level 10 |

- Locked badges are visually greyed out
- Unlocked badges display a gold *UNLOCKED* stamp
- A summary label tracks progress (e.g., "3 out of 8 Badges Unlocked! Keep it up!")

---

### 🧑‍🎤 5. Avatar Customization Shop (sidebar_avatar)

Students can personalize their profile using collectible avatars purchased with XP.

| Avatar | Cost | Availability |
|---|---|---|
| 🥚 Egg | Free | Default — always equipped |
| 👧 Girl | 200 XP | Purchasable |
| 👦 Boy | 200 XP | Purchasable |
| 🍌 Banana | 300 XP | Purchasable |

*Shop Mechanics*
- Clicking an avatar item shows its price, your current XP, and unlock status
- Purchasing deducts XP and permanently unlocks the avatar
- The *Apply Avatar* button equips the selected (unlocked) avatar
- The equipped avatar is reflected in the dashboard sidebar profile picture
- Avatar state (equipped, unlocked) is saved to avatar.json and persists between sessions

---

### 📊 6. Leaderboard (sidebar_leaderboard)

A weekly competitive leaderboard encourages friendly rivalry.

- Players are ranked by *Total Earned XP* (descending)
- The current user is highlighted in *gold*
- A *podium display* (1st, 2nd, 3rd) is shown at the top
- Ranks 4–6 are displayed in a list below
- The leaderboard refreshes automatically whenever XP changes
- The week start date is displayed (e.g., "Week of May 05, 2025")
- Your rank is shown in a motivational message (e.g., "You are #2 this week! Study Hard!")

---

### 🏠 7. Dashboard (sidebar_dashboard)

The dashboard is the home screen and provides a summary of all player stats.

| Component | Description |
|---|---|
| Greeting | Personalized welcome message using the logged-in username |
| Total XP | Current spendable XP balance |
| Tasks Done | Number of completed tasks |
| Rank | Current leaderboard position (formatted as ordinal: 1st, 2nd, etc.) |
| Day Streak | Consecutive days with at least one task completed |
| Weekly Calendar | Highlights today's day of the week |
| Today's Tasks | Lists all tasks due today or within the next 24 hours |
| Notes Editor | A rich text box for free-form study notes, auto-saved on every keystroke |

---

### 🔥 8. Streak System (StreakDatabase)

The streak system rewards consistent daily engagement.

- A streak increments by 1 each day a task is completed
- Completing multiple tasks on the same day counts as one streak day
- If a day is skipped entirely, the streak *resets to 1* on the next completion
- Streak data is stored in streak.json and checked on every task completion
- Streak count feeds directly into badge unlock conditions and the dashboard display

---

### 🏗️ System Architecture

StudyQuest uses a *multi-form shell architecture* where dashboard_ui acts as the host container. Sub-panels (Dashboard, Tasks, Leaderboard, Badges, Avatar) are embedded as TopLevel = false child forms within a shared pnlFormLoader panel.

*Key Design Patterns Used:*

| Pattern | Where Applied |
|---|---|
| *Singleton* | sidebar_task — ensures one shared task/XP state throughout the session |
| *Observer / Event-Driven* | EXPChanged static event — notifies all panels of XP changes |
| *Repository* | TaskDatabase, AvatarDatabase, StreakDatabase, NotesDatabase — abstract JSON I/O |
| *Factory via Generics* | ShowPanel<T>(ref T?, Func<T>) — lazily instantiates sub-panels on demand |

---

### ⚙️ How the Program Works

**Step-by-step breakdown:**
 
1. **Login** — The student logs in and lands on the Dashboard, which loads their current XP, streak, rank, and notes.
2. **Add Tasks** — On the Task page, the student creates study tasks by entering a title, description, and deadline.
3. **Complete Tasks** — Checking a task as done marks it complete, awards XP, and updates the Task Done counter on the Dashboard.
4. **Earn XP & Level Up** — XP accumulates from task completions. The sidebar progress bar fills up as the student approaches the next level.
5. **Climb the Leaderboard** — The Weekly Leaderboard ranks all students by XP. The student can monitor their rank and compete with classmates.
6. **Unlock Badges** — Consistent performance (streaks, task milestones) automatically unlocks achievement badges.
7. **Customize Avatar** — Students can personalize their avatar to represent themselves in the app.

---

### 💾 Data Persistence

All application data is stored locally as *JSON files* in the application's output directory. No external database or internet connection is required.

| File | Class | Contents |
|---|---|---|
| tasks.json | TaskSaveData | All tasks, current XP, total earned XP, level, completed/missed counts |
| avatar.json | AvatarData | Equipped avatar name, unlocked status of each avatar |
| streak.json | StreakData | Current streak count, date of last streak activity |
| notes.json | NotesData | Notes text content, last saved timestamp |

Data is loaded on application start and saved after every meaningful state change (task completion, avatar purchase, notes edit, logout).

---

### 🚀 How to Run the Application

### System Requirements

| Requirement | Details |
|---|---|
| Operating System | Windows 10 or Windows 11 |
| Runtime | [.NET 6.0 SDK or later](https://dotnet.microsoft.com/download/dotnet/6.0) |
| IDE | Visual Studio 2022 (Community or higher) |
| Architecture | x64 or x86 (Windows Forms) |

### Installation & Setup

*Step 1 — Clone the Repository*
git clone https://github.com/imjadead/StudyQuest
cd StudyQuest

*Step 2 — Open the Solution*
- Launch *Visual Studio 2022*
- Select *File → Open → Project/Solution*
- Navigate to and open StudyQuest.sln

*Step 3 — Restore Dependencies*

Visual Studio will automatically restore NuGet packages. If not, run:
dotnet restore

*Step 4 — Build the Project*
- Go to *Build → Build Solution* or press Ctrl + Shift + B
- Ensure there are no build errors in the Output window

*Step 5 — Run the Application*
- Press F5 to launch with the debugger, or Ctrl + F5 to run without
- The login window will appear

*Step 6 — Login with Default Credentials*
Username : admin
Password : 1234

⚠️ **Note:** Save files (`tasks.json`, `avatar.json`, `streak.json`, `notes.json`) are automatically generated in the build output directory (`/bin/Debug/net6.0-windows/`) on first run. Do not manually delete these files unless you intend to reset all progress.


---

### 📁 Project Structure
StudyQuest/
│
├── 📄 StudyQuest.sln                  
│
├── 📁 Forms/
│   ├── login_ui.cs                  
│   ├── dashboard_ui.cs              
│   ├── sidebar_dashboard.cs           
│   ├── sidebar_task.cs               
│   ├── sidebar_leaderboard.cs         
│   ├── sidebar_badges.cs             
│   └── sidebar_avatar.cs             
│
├── 📁 Data/
│   ├── TaskDatabase.cs                
│   ├── AvatarDatabase.cs             
│   ├── StreakDatabase.cs             
│   └── NotesDatabase.cs            
│
├── 📁 Models/
│   ├── GameSession.cs               
│   ├── TaskData.cs / TaskSaveData.cs 
│   ├── AvatarData.cs               
│   ├── StreakData.cs                
│   └── NotesData.cs                  
│
└── 📁 Save Files 
    ├── tasks.json
    ├── avatar.json
    ├── streak.json
    └── notes.json


---

### 👨‍💻 Developers / Team Members

| Name | GitHub | Role |
|------|--------|------|
| Atienza, Dhanreigh I | https://github.com/Dadanchiii | Lead Developer |
| Coballes, Jade Ann | https://github.com/imjadead | UI/UX Designer |
| Mayuga, Nash | https://github.com/shany20 | Backend / Logic |
| Fabellar, Frances Iroll | https://github.com/Noobit2 | Backend / Logic |
