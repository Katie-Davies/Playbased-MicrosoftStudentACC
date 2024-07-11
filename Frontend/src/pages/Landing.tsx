import girlPainting from '../assets/girlpaint.jpg'

function Landing() {
  return (
    <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
      <img
        src={girlPainting}
        alt="Little girl covered in paint"
        className="w-full h-auto sm:h-64 md:h-screen col-span-1"
      />
      <h1 className="col-span-1 md:col-span-2 text-center md:text-left">
        Landing Page
      </h1>
    </div>
  )
}

export default Landing
