/** @type {import('tailwindcss').Config} */
export default {
  content: ['./index.html', './src/**/*.tsx', './src/*.tsx'],
  theme: {
    extend: {
      fontFamily: {
        sueEllen: ['"Sue Ellen Francisco"', 'cursive'],
        montserrat: ['Montserrat', 'sans-serif'],
      },
    },
  },
  plugins: [],
}
