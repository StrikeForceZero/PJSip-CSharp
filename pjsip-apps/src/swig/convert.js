const fs = require('fs');

const ord = s => s.charCodeAt(0);

const log = process.stdout.write.bind(process.stdout);

function logStep(message, stepOrValue, logResult = false) {
    log(`${message}${logResult ? ': ' : '... '} `);
    const result = typeof stepOrValue === 'function' 
        ? stepOrValue() 
        : stepOrValue;
    logResult 
        ? log(`${result.toString()}\n`) 
        : log('Done.\n');
    return result;
}

let file = logStep('Reading symbols.i', _ => fs.readFileSync('symbols.i'));

file = file.toString().replace(/\(\((?:\('(.)'\s<<\s(\d+)\)?\s\|\s)(?:\('(.)'\s<<\s(\d+)\)\)?\s\|\s)(?:\('(.)'\s<<\s(\d+)\)\)?\s\|\s)'(\s|\w)?'/g, (match, ...groupsOffsetAndInputString) => {
    const groups = groupsOffsetAndInputString.slice(0, groupsOffsetAndInputString.length - 2);
    const parsedSymbol = ord(groups[6]) << 24 | ord(groups[4]) << 16 | ord(groups[2]) << 8 | ord(groups[0]);
    return logStep(match.slice(2), parsedSymbol, true);
})

logStep('Writing symbols_csharp.i', _ => fs.writeFileSync('symbols_csharp.i', file));


log('complete\n');