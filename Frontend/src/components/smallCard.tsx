import {
  Card,
  CardContent,
  CardMedia,
  Typography,
  CardActionArea,
} from '@mui/material'
import { styled } from '@mui/system'
import girlPaint from '../assets/girlpaint.jpg'

// Custom styles using the styled utility
const CustomCard = styled(Card)(({ theme }) => ({
  border: '3px solid #BF8C80',
  maxWidth: 345,
  borderRadius: '20%',
}))

const CustomCardMedia = styled(CardMedia)(({ theme }) => ({
  border: '3px solid #588c7e',
  borderRadius: '8px',
  height: '200px',
  margin: '10px',
  width: '75%',
}))

const CustomTypography = styled(Typography)(({ theme }) => ({
  fontFamily: 'Sue Ellen Francisco, cursive',
  fontSize: '2rem',
  color: '#Bf8c80',
}))

function SmallCard() {
  function handleClick() {
    console.log('Button clicked')
  }
  return (
    <div className="m-5">
      <CustomCard>
        <CardActionArea onClick={handleClick}>
          <div
            style={{
              display: 'flex',
              justifyContent: 'center',
              alignItems: 'center',
              height: '200px',
              marginTop: '20px',
            }}
          >
            <CustomCardMedia
              component="img"
              image={girlPaint}
              alt="Girl painting"
              style={{ objectFit: 'cover', borderRadius: '8px' }}
            />
          </div>

          <CardContent>
            <div
              style={{
                display: 'flex',
                justifyContent: 'center',
                alignItems: 'center',
                height: 'auto',
              }}
            >
              <CustomTypography gutterBottom variant="h5" component="div">
                Chalk Painting
              </CustomTypography>
            </div>
          </CardContent>
        </CardActionArea>
      </CustomCard>
    </div>
  )
}

export default SmallCard
