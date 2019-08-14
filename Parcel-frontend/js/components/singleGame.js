export default function SingleGame(game, characters){
    return `
        <div class = 'single-game'>
            
            <div class = 'random-char'>
            <div class = 'image-and-desc'>
            <img class="gameimg" src = ${game.image}>
            <iframe class="iframe" width="560" height="315" src="https://www.youtube.com/embed/${game.video}" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
            </div>
            <p class="gameDescription"> ${game.description}</p>
            <a href = "${game.download}" target ='_blank'><button class="download"> Download Game </button></a>                               
            </div>
           
            <div class='single-button'>
            <button input class='single-quiz' type='hidden' value="${game.gameId}">Take Quiz for this Game</button>
            <button input class='single-game-chars' type='hidden' value="${game.gameId}">View All Characters for this Game<button>
            </div>
            
            })
        </div>
        
         `
}
