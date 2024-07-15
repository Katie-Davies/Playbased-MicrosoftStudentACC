import Card from '@mui/material/Card'
import CardContent from '@mui/material/CardContent'
import CardMedia from '@mui/material/CardMedia'
import Typography from '@mui/material/Typography'
import { CardActionArea, CardActions } from '@mui/material'
import Button from './Button'
import girlPaint from '../assets/girlpaint.jpg'

function SmallCard() {
  const Style = {
    height: '200px',
  }
  return (
    <div className="m-5">
      <Card key={5} sx={{ maxWidth: 345 }}>
        <CardActionArea>
          <CardMedia
            component="img"
            style={Style}
            image={girlPaint}
            alt="Girl painting"
          />
          <CardContent>
            <Typography gutterBottom variant="h5" component="div">
              Chalk Painting
            </Typography>
          </CardContent>
          <CardActions disableSpacing={true}>
            <Button>More</Button>
          </CardActions>
        </CardActionArea>
      </Card>
    </div>
  )
}
export default SmallCard
