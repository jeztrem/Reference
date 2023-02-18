Syntactically Awesome Style Sheets (Sass) is a preprocessor scripting language that is interpreted and compiled into Cascading Style Sheets (CSS).

#### Example variable
$color-primary: blue;
.button {
  background-color: $color-primary;
} 


####Compiling
1. Node.js  
    npm install sass -g
    sass [input-path] [output-path]
    or
    sass [input-path] [output-path] [settings]

    Useful settings
    --style=expanded – Generates a compressed and minified CSS file.
    --no-source-map – Prevents the generation of a source map file. This file maps the transformed source to the original source so that the browser can show the original in the debugger.
    --watch – Watches for any changes in your file and recompiles automatically.


2. VS Code
    install the Live Sass Compiler extension

    click Watch Sass in the Status Bar when you have a SCSS or SASS file open to activate the live Sass compiler.

    this is in the lower right corner

    careful this compiles every sass file.
