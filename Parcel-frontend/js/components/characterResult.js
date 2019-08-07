export default function CharacterResult(characters, aesthetic){
    characters.sort(function(a,b){
        if(b.aesthetic == aesthetic){
            return 1
        }
        return a.aesthetic - b.aesthetic
    })
    console.log(characters);
    return `
   <div class = "char-results">
    ${characters.map(character =>{
        if(character.aesthetic == aesthetic && characters.indexOf(character) == 0)
        return `
        <div class= "char-single-result">
        <a href= "${character.characterUrl}" target="_blank">
        <img src=${character.image}>            
        <p>${character.name}</p>
        </a>

        </div>
        `
        else
        return `
        <div class= "char-single-result">
        <a href= "${character.characterUrl}" target="_blank">
        <img src=${character.smallImage}>            
        <p>${character.name}</p>
        </a>

        </div>
        `   

    }).join("")}
   </div>
   <button value='1' class="allChar">View All Characters</button>
    `
}