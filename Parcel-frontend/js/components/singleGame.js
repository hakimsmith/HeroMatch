export default function SingleGame(game, characters){
    return `
        <div class = 'single-game'>
            
            <div class = 'random-char'>
            <a> ${game.name}<a/>
            <p> ${game.description}</p>
            <img src = ${game.image}>
            <iframe width="560" height="315" src="https://www.youtube.com/embed/${game.video}" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
            <a href = "${game.download}" target ='_blank'> Download Game <a>                               
            </div>
           
            <div class='single-button'>
            <button input class='single-quiz' type='hidden' value="${game.gameId}">Take Quiz for this Game</button>
            <button input class='single-game-chars' type='hidden' value="${game.gameId}">View All Characters for this Game<button>
            </div>
            
            })
        </div>
        
         `
}
