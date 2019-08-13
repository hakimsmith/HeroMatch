export default function SingleGame(game){
    return `
        <div class = 'single-game'>
            
            <div class = 'random-char'>
            <a> ${game.name}<a/>
            <p> ${game.description}</p>
            <img src = ${game.image}>
            <iframe width="560" height="315" src="https://www.youtube.com/embed/${game.video}" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
            <a href = "${game.download}" target ='_blank'>                                 
            </div>
            
        </div>
    `
}