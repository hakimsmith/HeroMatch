import ApiActions from './api/api-actions'
import TakeQuiz from './components/takeQuiz';
import Home from './components/home';
import CharacterQuiz from './components/characterQuiz';
import CharacterResult from './components/characterResult';
import SubroleOptions from './components/subrole-options';
import AllChars from './components/all-chars';
import BaseStyle from './components/style-components/base-style';
import AestheticOptions from './components/aesthetic-options'
import apiActions from './api/api-actions';
import SingleChar from './components/singlechar';
import { isArray } from 'util';

console.log("app.js");

pageBuild();

function pageBuild(){
    home();
    characterQuiz();
    allChars();
    //baseStyle();
    takeQuiz();
    GetAna();
    
};

// function baseStyle(){
//     document.getElementById('nav_home').addEventListener('click', function(){

        
//             apiActions.getRequest('https://localhost:44399/api/game', games =>{
//                 document.innerHTML = BaseStyle(Home(games));

//             }
//             )
    
//     })
// }

function home(){
    const body = document.getElementById('about');
    const home = document.getElementById('nav_home');
    home.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44399/api/game', games =>{
        body.innerHTML = Home(games);
        document.getElementById('quiz').innerHTML = '';
        })
    });
};

function takeQuiz(){
    const body = document.getElementById('about');
    const quiz = document.getElementById('nav_quiz');
    quiz.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44399/api/game', games =>{
        body.innerHTML = TakeQuiz(games);
        document.getElementById('quiz').innerHTML = '';
        })
    });
}

function allChars(){
    document.getElementById('about').addEventListener('click', function(){
        let gameId = 0;

        if(event.target.classList.contains('allChar')){
            gameId = event.target.value
            ApiActions.getRequest('https://localhost:44399/api/game/'+ gameId, game => {
                    document.querySelector('#about').innerHTML = AllChars(game);
                }
            )
        }

        if(event.target.classList.contains('single-char')){
            gameId = event.target.parentElement.querySelector('.gameid').value
            //video = event.target.parentElement.querySelector('video').value
            let image = event.target.parentElement.querySelector('.image').value
            let apiLocation = event.target.parentElement.querySelector('.apiLocation').value

            apiActions.getRequest(apiLocation, char => {
                console.log(char)
                let chardata = Object.values(char.data)[0]
                console.log(chardata)
                document.querySelector('#about').innerHTML = SingleChar(chardata, gameId,video,image);
            })
        }

    })
}

function characterQuiz(){
    let difficulty = 0;
    let role = 0;
    let subrole = 0;
    let aesthetic = 0;

    document.addEventListener('click', function(){
        if(event.target.classList.contains('select-game')){
            console.log('event')
            let gameId = event.target.parentElement.querySelector('.select-game__id').value
            document.getElementById('quiz').innerHTML = CharacterQuiz(gameId);
            if(gameId == 2){
                document.getElementById('optional').innerHTML= AestheticOptions();
                document.getElementById('optional').style.display="block";
            }
        }
    })

    document.querySelector('#quiz').addEventListener('click', function(){
        if(event.target.classList.contains('diffOption')){
            difficulty = event.target.value
            console.log(difficulty)
            console.log(role)
            console.log(subrole)
        }

        if(event.target.classList.contains('roleOption')){
            role = event.target.value
            console.log(difficulty)
            console.log(role)
            console.log(subrole)
            document.getElementById('subroleOptions').innerHTML = SubroleOptions(role);
        }
        
        if(event.target.classList.contains('subRoleOption')){
            subrole = event.target.value
            console.log(difficulty)
            console.log(role)
            console.log(subrole)
        }
        if(event.target.classList.contains('aestheticOption')){
            aesthetic = event.target.value
            console.log(difficulty)
            console.log(role)
            console.log(subrole)
            console.log(aesthetic)
        }
        
        

        if(event.target.classList.contains('submit-button')){
            
            difficulty = difficulty
            role = role
            subrole = subrole
            aesthetic = aesthetic
            let gameid = document.getElementById('charquiz_gameId').value
            
            ApiActions.getRequest('https://localhost:44399/api/characters/'
            +gameid+'/'+difficulty +'/'+role+'/'+subrole , characters => {
                document.querySelector('#about').innerHTML = CharacterResult(characters, aesthetic);
                
            })
            
        }  
        
    
        var coll = document.getElementsByClassName("Question_Head");
        var i;
        for (i = 0; i < coll.length; i++) {
        coll[i].addEventListener("click", function() {
        this.classList.toggle("active");
        var content = this.nextElementSibling;
        if (content.style.maxHeight) {
            content.style.maxHeight = null;
        } else {
            content.style.maxHeight = content.scrollHeight + "px";
        }
        });
        }
    })
    document.querySelector("#about").addEventListener("click", function(){ 
        if(event.target.classList.contains('switch-game')){
            console.log(gameid)
            difficulty = difficulty
            role = role
            subrole = subrole
            aesthetic = aesthetic
            let gameid = document.getElementById('charquiz_gameId').value

            if(gameid == 2){
                gameid = 1
                aesthetic = 0

                ApiActions.getRequest('https://localhost:44399/api/characters/'
                +gameid+'/'+difficulty +'/'+role+'/'+subrole , characters => {
                    document.querySelector('#about').innerHTML = CharacterResult(characters, aesthetic);
                    document.querySelector('#quiz').style.display = 'none' 
                })
            }
            else{
                gameid = 2
                aesthetic = 0

                ApiActions.getRequest('https://localhost:44399/api/characters/'
                +gameid+'/'+difficulty +'/'+role+'/'+subrole , characters => {
                    document.querySelector('#about').innerHTML = CharacterResult(characters, aesthetic);
                    document.querySelector('#quiz').style.display = 'none' 
                })
                
            }
        }
        })
}

function GetAna(){
    document.getElementById('about').addEventListener('click', function(){
        if (event.target.classList.contains('get-ana')){
            apiActions.getRequest('https://overwatch-api.net/api/v1/hero/1', ana =>{
                document.querySelector('#about').innerHTML = SingleChar(ana)
            })
        }
    })
}


