export default function CharacterResult(characters, aesthetic){
    characters.sort(function(a,b){
        if(b.aesthetic == aesthetic){
            return 1
        }
        return a.aesthetic - b.aesthetic
    })
    return `
    <h1 class='result-head'>Results</h1>
    <br />
    <div class = "char-results">
    ${characters.map(character =>{
        if(character.aesthetic == aesthetic && characters.indexOf(character) == 0)
        return `
        <div>
        <div class= "char-single-result">
            <h2 class='top-pick'>Top Pick</h2>
            <img class='single-char' src=${character.image}>            
            <p class='single-char-name'>${character.name}</p>
            <input class='gameid' value=${character.gameId} type='hidden'>
            <input class='apiLocation' value=${character.apiLocation} type='hidden'>
            <input class='video' value=${character.video} type = 'hidden'>
            <input class='image' value=${character.image} type ='hidden'>
        </div>
        <h2>Close Matches</h2>
        </div>
        `
        else
        return `
        <div class='char-other-result'>
            <div class="single-char-group">
                <div class="imgNameOther">
                <img class='single-char' src=${character.smallImage}>                      
                <p class='single-char-name'>${character.name}</p>
                </div>
                <input class='gameid' value=${character.gameId} type='hidden'>
                <input class='apiLocation' value=${character.apiLocation} type='hidden'>
                <input class='video' value=${character.video} type = 'hidden'>
                <input class='image' value=${character.image} type ='hidden'>
            </div>
        </div>
        `   

    }).join("")}
   </div>
   <div class='buttons'>
   <button value='${characters[0].gameId }' class="allChar quiz-button">View All Characters For This Game</button>
   <button class='switch-game quiz-button'>View Similar Characters for Other Game</button>
   </div>
    `
}