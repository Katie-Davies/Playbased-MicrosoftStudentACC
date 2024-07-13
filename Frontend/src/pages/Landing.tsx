import girlPainting from '../assets/girlpaint.jpg'
import logo from '../assets/Logo500x500.png'

function Landing() {
  return (
    <div className="grid grid-cols-1 md:grid-cols-3 gap-4 place-items-center">
      <img
        src={girlPainting}
        alt="Little girl covered in paint"
        className="w-2/3  md:w-full h-auto sm:h-auto md:h-screen col-span-1"
      />

      <div className="col-span-1 md:col-span-2 text-center md:text-left">
        <div className="flex flex-col justify-center content-center flex-wrap h-screen items-center">
          <img
            src={logo}
            alt="Bright Beginnings Logo"
            className="w-1/2 h-auto mx-auto md:ml-0"
          />
          <h1 className="text-center font-sueEllen text-6xl md:text-8xl">
            Learn Create Play
          </h1>
        </div>
      </div>
    </div>
  )
}

export default Landing
