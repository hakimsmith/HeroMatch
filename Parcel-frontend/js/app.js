import Home from './components/home';
import GameQuiz from './components/gameQuiz';
import CharacterQuiz from './components/characterQuiz';

console.log("app.js");

pageBuild();

function pageBuild(){
    console.log("page build");
    home();
    characterQuiz();
    
};

function home(){
    const body = document.getElementById('root');
    const home = document.getElementById('nav_home');
    home.addEventListener('click', function(){
        body.innerHTML = Home();
    });
};

function characterQuiz(){
    let difficulty = 0;
    let role = 0;
    let subrole = 0;

    document.getElementById('quizbutton').addEventListener('click', function(){
        document.getElementById('quiz').innerHTML = CharacterQuiz();
    })

    document.querySelector('#quiz').addEventListener('click', function(){
        if(event.target.classList.contains('option')){
            difficulty = event.target.value
            console.log(difficulty)
        }
    })

};

