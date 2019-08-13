export default function SingleGame(game){
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
            
        </div>
    `
}