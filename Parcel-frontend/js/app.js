import Home from './components/home';
import CharQuiz from './components/character-quiz';

pageBuild();

function pageBuild(){
    home();
    charQuiz();
    
}

function home(){
    const body = document.getElementById('root');
    const home = document.getElementById('nav_home');

    home.addEventListener('click', function(){
        body.innerHTML = Home();
    });
};

function charQuiz(){
    const quizContainer = document.getElementById('quiz');
    const resultsContainer = document.getElementById('results');
    const submitButton = document.getElementById('submit');
}


function showResults(){
    submitButton.addEventListener('click', showResults);
}