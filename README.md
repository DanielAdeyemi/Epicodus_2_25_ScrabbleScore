## <div align="center">Scrabble Score C#</div>
#### <div align="center">📚 *Epicodus Practice Lesson # 25  (Week 1 of C#)  2/25/2021* </div> 
***<p align="right">By Daniel Adeyemi and Mike Pingel ***</p>   
<p align="center">
<br>

<img alt="C#" src="https://img.shields.io/badge/c%23%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white"/>
<img alt="made with Bash" src="https://img.shields.io/badge/Made%20with-Bash-1f425f.svg"/>
</p>

___
### 📇 This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.
___
## 🚩 *Description*:    
### *...*


## 🔧 *Setup/Installation instructions:*
#### 🌐 From the web:
* Go to my GitHub repository, using following [URL](https://github.com/DanielAdeyemi/Epicodus_2_25_ScrabbleScore.git).
* Click the "Code" ![img](img/code.png) and click the 'Download zip' option ![img](img/zip.png).
* Unzip the file, navigate to the `Models` directory to check code or to the `ModelTests` directory to see tests.
#### ⚙️ From the terminal: 
* Clone my repository from GitHub using `git clone https://github.com/DanielAdeyemi/Epicodus_2_25_ScrabbleScore.git` in your terminal or GitBash
* Navigate to the downloaded folder using ***cd*** command
* Execute **code .** command in your terminal and it will open all source code in your code editor.    
⚠️ *Note: To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running dotnet --version in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet)*
### 📋 Specs:
<details>
<summary>🚥 Tests</summary>

| # | Behavior | Input |  Output | Complete |
| :------------- | :------------- | :------------- | :------------ | :-------------: |
| 01 | For empty string display 0 | "" | 0 |❌|
| 02 | For each vowel in a string add 1 point | aourt | 3 |❌ |
| 03 | If string has D or G add 2 points for each appearance | aourtdg | 7 | ❌|
| 04 | If string has B, C, M, P add 3 points for each appearance| aodbmy | 10 | ❌|
| 05 | If string has F, H, V, W, Y add 4 points for each appearance | aodbmy| 14 | ❌ |
| 06 | If string has K add 5 points for each appearance | audfk | 13 | ❌  |
| 07 | If string has J, X add 8 points for each appearance | audfkj | 21 | ❌  |
| 08 | If string has Q, Z add 10 points for each appearance | audfkjz | 31 | ❌  |
| 09 |  |  |  | ✅  |
| 10 |  | | | ❌ |

</details>



#### 🏁 Running Tests:
* To run MS tests you will need to navigate to the `ToDoList.Tests` folder *(cd ToDoList.Tests)* in the command line and then run `dotnet restore`.
* You should now see **'obj'** folders in both the `ToDoList.Tests` folder and `ToDoList` folder.
* At this point you should be able to successfully run `dotnet test` in the command line (keep in mind you should still be in the ToDoList.Tests folder).

####  🖥️ View website:
*GitHub page or terminal interactions are unavailable for this project.*

## 🛠️ *Technologies used:*
* C# v.9
* .NET Core v5.0
* MSTest
* REPL
* Git and GitHub

## 🐛 *Known bugs:*
This project has no execution in terminal and was used to practice TDD in C# with MSTest.

## 📘 *License and copyright:*

> ***© Daniel Adeyemi, Mike Pingel, 2021***  
> ⚖️ *[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)*