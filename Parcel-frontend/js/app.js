import Home from './components/home';
import GameQuiz from './components/gameQuiz';
import CharacterQuiz from './components/characterQuiz'


pageBuild();

function pageBuild(){
    home();
    
}

function home(){
    const body = document.getElementById('root');
    const home = document.getElementById('nav_home');
    home.addEventListener('click', function(){
        body.innerHTML = Home();
    });
};

