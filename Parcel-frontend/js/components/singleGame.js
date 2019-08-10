export default function SingleGame(game){
    return `
        <div class = 'single-game'>
        ${game.map(game =>{
            return `
            <div class = 'random-char'>
            <a> ${game.name}<a/>
            <p> ${game.description}</p>
            <img src = ${game.image}>
            <a> ${game.video}</a>
            <a href = "${game.download}" target ='_blank'>                                 
            </div>
            `
        }).join("")}
        </div>
    `
}