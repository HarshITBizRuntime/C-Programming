const path = require('path');
const ExtractTextPlugin = require("extract-text-webpack-plugin");

module.exports = {
    entry: './source/index.js',
    output : 
    {
        filename : 'bundle.js',
        path: path.resolve(__dirname,'dist')
    },
    module: {
             rules: [
               {
                 test: /\.css$/,
                 use: [
                   'style-loader','css-loader'
                 ]
               }/*,
               {
                 test: /\.css$/,
        use: ExtractTextPlugin.extract({
          fallback: "style-loader",
          use: ["css-loader","scss-loader"]
        })
       }*/
      ]
    }
   /* plugins: [
      new ExtractTextPlugin("styles.css"),
    ]*/
};